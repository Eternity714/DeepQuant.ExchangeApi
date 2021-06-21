using Newtonsoft.Json.Linq;
using System;

namespace ExchangeApi
{
    public interface IMarket
    {
        string GlobalId { get; }

        string Symbol { get; }

        string BaseCurrency { get; }

        string QuoteCurrency { get; }

        string BaseId { get; }

        string QuoteId { get; }

        bool Active { get; }

        ITradingFee Fee { get; }

        /// <summary>
        /// 费用是否取决于你的交易级别(你的交易量)
        /// </summary>
        bool TierBased { get; }

        /// <summary>
        /// 价格的小数位数, -1即交易所未提供
        /// </summary>
        int PricePrecision { get; }

        /// <summary>
        /// 成交量的小数位数, -1即交易所未提供
        /// </summary>
        int AmountPrecision { get; }

        /// <summary>
        /// 成交额的小数位数, -1即交易所未提供
        /// </summary>
        int CostPrecision { get; }

        ILimit PriceLimit { get; }

        ILimit AmountLimit { get; }

        ILimit CostLimit { get; }

        JToken RawData { get; }
    }
}
