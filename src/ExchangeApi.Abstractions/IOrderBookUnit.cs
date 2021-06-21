using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IOrderBookUnit
    {
        double Price { get; }

        double Amount { get; }
    }
}
