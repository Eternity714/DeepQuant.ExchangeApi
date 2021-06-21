using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IBalance
    {
        string Name { get; }

        double Free { get; }

        double Used { get; }

        double Total { get; }
    }
}
