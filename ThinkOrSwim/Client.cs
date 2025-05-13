using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkOrSwim
{
    public enum QuoteType
    {
        TOPICLIST,
        //52HIGH
        //52LOW
        ACT_WARNING,
        ASK,
        ASKX,
        ASK_SIZE,
        AV_TRADE_PRICE,
        AX,
        BACK_EX_MOVE,
        BACK_VOL,
        BA_SIZE,
        BETA,
        BID,
        BIDX,
        BID_SIZE,
        BX,
        CALL_VOLUME_INDEX,
        CLOSE,
        COST,
        COVERED_RETURN,
        CUSTOM1,
        CUSTOM10,
        CUSTOM11,
        CUSTOM12,
        CUSTOM13,
        CUSTOM14,
        CUSTOM15,
        CUSTOM16,
        CUSTOM17,
        CUSTOM18,
        CUSTOM19,
        CUSTOM2,
        CUSTOM3,
        CUSTOM4,
        CUSTOM5,
        CUSTOM6,
        CUSTOM7,
        CUSTOM8,
        CUSTOM9,
        DELTA,
        DESCRIPTION,
        DIV,
        DIV_FREQ,
        //EPR Lower,
        //EPR Upper,
        EXCHANGE,
        EXPIRATION,
        EXPIRATION_DAY,
        EXTRINSIC,
        //EXT_%CHNG,
        EXT_LAST,
        EXT_NET_CHNG,
        EX_DIV_DATE,
        X_MOVE_DIFF,
        FRONT_EX_MOVE,
        FRONT_VOL,
        FX_PAIR,
        GAMMA,
        HIGH,
        HTB_ETB,
        HTB_RATE,
        HTB_SHARES_AVAILABLE,
        IMPL_VOL,
        INITIAL_MARGIN,
        INTRINSIC,
        LAST,
        LASTX,
        LAST_SIZE,
        LOW,
        LX,
        MARK,
        MARKET_CAP,
        MARK_CHANGE,
        MARK_PERCENT_CHANGE,
        MARK_PERCENT_UNDERLYING,
        MAX_COVERED_RETURN,
        MRKT_MKR_MOVE,
        MT_NEWS,
        NAME,
        NET_CHANGE,
        OPEN,
        OPEN_INT,
        OPTION_VOLUME_INDEX,
        PE,
        PERCENT_CHANGE,
        PERCENT_IN_THE_COLUMN,
        PERCENT_OUT_THE_MONEY,
        POSITION_N_L,
        POSITION_QTY,
        PROB_OF_EXPIRING,
        PROB_OF_TOUCHING,
        PROB_OTM,
        PUT_CALL_RATIO,
        PUT_VOLUME_INDEX,
        P_L_DAY,
        P_L_OPEN,
        P_L_PERCENT,
        P_L_YTD,
        QUOTE_TREND,
        RHO,
        ROC,
        ROR,
        SHARES,
        SM_AVERAGE_MENTIONS_PER_HOUR,
        SM_DAY_TO_EIGHT_WEEKS_RATIO,
        SM_DAY_TO_WEEK_RATIO,
        SM_HOUR_TO_WEEK_RATIO,
        SM_LAST_DAY_MENTIONS,
        SM_LAST_HOUR_MENTIONS,
        SM_WEEK_TO_EIGHT_WEEKS_RATIO,
        STOCK_BETA,
        STRENGTH_METER,
        STRIKE,
        SYMBOL,
        THETA,
        TICK_SIZE,
        TICK_VALUE,
        TODAY_CLOSE,
        TOTAL_COST,
        VEGA,
        VOLUME,
        VOL_DIFF,
        VOL_INDEX,
        WEIGHTED_BACK_VOL,
        YIELD
    }

    public class Client : IDisposable
    {
        Feed feed;

        public Client() : this(10)
        {

        }

        public Client(int heartbeat)
        {
            this.feed = new Feed(heartbeat);
        }

        public void Add(string symbol, QuoteType quoteType)
        {
            this.feed.Add(symbol, quoteType.ToString());
        }

        public void Remove(string symbol, QuoteType quoteType)
        {
            this.feed.Remove(symbol, quoteType.ToString());
        }

        public IEnumerable<Quote> Quotes()
        {
            return this.feed;
        }

        public void Dispose()
        {
            this.feed.Stop();
        }
    }
}
