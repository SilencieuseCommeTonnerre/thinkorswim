using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkOrSwim;

namespace ConsoleQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Add("", QuoteType.TOPICLIST);
            client.Add("/ES:XCME", QuoteType.LAST);
            client.Add("/NQ:XCME", QuoteType.LAST);
            client.Add("/YM:XCME", QuoteType.LAST);
            client.Add("/ES", QuoteType.LAST);
            

            foreach (var quote in client.Quotes())
            {
                Console.WriteLine("{0} {1}: ${2}", quote.Symbol, quote.Type, quote.Value);
            }
        }
    }
}
//TODO: Add WebSocket support
//TODO: Support adding or deleting multiple WebSocket clients that can add or remove multiple topic subscriptions
//TODO: Manage topic subscriptions so that multiple clients can add the same topic and recieve the same data
//      but only one subscription request is made to the RTD server.  If one client removes the topic, it should
//      not remove the topic from the RTD server until all clients have removed it.
//TODO: Add code to fix broken futures symbols using the following list
/*
/ES:XCME
/NQ:XCME
/YM:XCBT
/RTY:XCME
/NKD:XCME
/EMD:XCME
/VX:XCBF
/BTC:XCME
/XBT:XCBF
/CL:XNYM
/QM:XNYM
/NG:XNYM
/QG:XNYM
/RB:XNYM
/HO:XNYM
/BZ:XNYM
/GC:XCEC
/MGC:XCEC
/SI:XCEC
/SIL:XCEC
/HG:XCEC
/PL:XNYM
/PA:XNYM
/ZB:XCBT
/ZN:XCBT
/ZF:XCBT
/ZT:XCBT
/UB:XCBT
/TN:XCBT
/GE:XCME
/ZQ:XCBT
/GLB:XCME
/6A:XCME
/M6A:XCME
/6B:XCME
/M6B:XCME
/6C:XCME
/6E:XCME
/E7:XCME
/M6E:XCME
/6J:XCME
/J7:XCME
/6M:XCME
/6N:XCME
/6S:XCME
/ZC:XCBT
/XC:XCBT
/ZS:XCBT
/XK:XCBT
/ZW:XCBT
/XW:XCBT
/KE:XCBT
/ZM:XCBT
/ZL:XCBT
/ZO:XCBT
/HE:XCME
/GF:XCME
/LE:XCME
/LBS:XCME
/FNG:IFUS
/MME:IFUS
/DX:IFUS
/YG:IFUS
/YI:IFUS
/CT:IFUS
/CC:IFUS
/KC:IFUS
/SB:IFUS
/OJ:IFUS
 */