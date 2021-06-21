using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IAddress
    {
        string Currency { get; }

        string Address { get; }

        string Tag { get; }

        JToken RawData { get; }
    }
}
