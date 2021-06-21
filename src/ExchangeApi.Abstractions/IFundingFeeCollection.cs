using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IFundingFeeCollection : IReadOnlyDictionary<string, IFundingFee>
    {
        JToken RawData { get; }
    }
}
