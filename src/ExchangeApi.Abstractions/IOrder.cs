using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IOrder
    {
        string OrderId { get; }

        string ClientOrderId { get; }

        DateTime CreateTime { get; }

        DateTime LastTradeTime { get; }

        OrderStatus Status { get; }

        string Symbol { get; }

        OrderType orderType { get; }

        OrderTimeInForce TimeInForce { get; }

        OrderSide OrderSide { get; }

        double Price { get; }

        /// <summary>
        /// 已成交均价
        /// </summary>
        double Average { get; }

        double Amount { get; }

        /// <summary>
        /// 已成交数量
        /// </summary>
        double Filled { get; }

        /// <summary>
        /// 未成交数量
        /// </summary>
        double Remaining { get; }

        /// <summary>
        /// 已成交金额
        /// </summary>
        double Cost { get; }

        IReadOnlyList<string> TradeIds { get; }



        JToken RawData { get; }
    }
}
