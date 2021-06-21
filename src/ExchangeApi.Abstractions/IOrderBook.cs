using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IOrderBook
    {
        public IReadOnlyList<IOrderBookUnit> Bids { get; }

        public IReadOnlyList<IOrderBookUnit> Asks { get; }

        public DateTime? DateTime { get; }
    }
}
