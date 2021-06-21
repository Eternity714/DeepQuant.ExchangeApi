using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface ITrade
    {
        string TradeId { get; }

        DateTime DateTime { get; }

        string Symbol { get; }

        string OrderId { get; }
        
        OrderType OrderType { get; }

        OrderSide OrderSide { get; }

        /// <summary>
        /// 成交价
        /// </summary>
        double Price { get; }

        /// <summary>
        /// 成交量
        /// </summary>
        double Amount { get; }

        JToken RawData { get; }
    }
}
