using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface ICurrency
    {
        string GlobalId { get; }

        string Code { get; }

        string Name { get; }

        bool Active { get; }

        IFundingFee Fee { get; }

        ILimit AmountLimit { get; }

        ILimit PriceLimit { get; }

        ILimit CostLimit { get; }

        ILimit WithdrawLimit { get; }

        JToken RawData { get; }
    }
}
