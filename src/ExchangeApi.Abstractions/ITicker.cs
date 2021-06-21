using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface ITicker
    {
        string Symbol { get; }

        DateTime? DateTime { get; }

        double High { get; }

        double Low { get; }

        double Open { get; }

        double Close { get; }

        /// <summary>
        /// 同Close
        /// </summary>
        double Last { get; }

        /// <summary>
        /// 上一次的收盘价
        /// </summary>
        double PreviousClose { get; }

        IOrderBookUnit BestBid { get; }

        IOrderBookUnit BestAsk { get; }

        /// <summary>
        /// 涨跌额, Last - Open
        /// </summary>
        double Change { get; }

        /// <summary>
        /// 涨跌幅, (Change / Open) * 100
        /// </summary>
        double Percentage { get; }

        /// <summary>
        /// 平均价, (Last + Open) / 2
        /// </summary>
        double Average { get; }

        /// <summary>
        /// 过去24小时内的交易货币成交量
        /// </summary>
        double BaseVolume { get; }

        /// <summary>
        /// 过去24小时内的报价货币成交量
        /// </summary>
        double QuoteVolume { get; }

        JToken RawData { get; }
    }
}
