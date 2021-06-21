using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    /// <summary>
    /// 转账费率
    /// </summary>
    public interface IFundingFee
    {
        string Currency { get; }

        double Withdraw { get; }

        double Deposit { get; }

        FeeRateMode RateMode { get; }
    }
}
