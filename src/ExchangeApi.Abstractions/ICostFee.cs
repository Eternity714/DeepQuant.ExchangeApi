using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    /// <summary>
    /// 已产生的手续费用
    /// </summary>
    public interface ICostFee
    {
        string Currency { get; }

        string Cost { get; }
    }
}
