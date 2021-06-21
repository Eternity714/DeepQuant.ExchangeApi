using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    /// <summary>
    /// 交易费率
    /// </summary>
    public interface ITradingFee
    {
        string Symbol { get; }

        double Maker { get; }

        double Taker { get; }

        FeeRateMode RateMode { get; }

        JToken RawData { get; }
    }
}
