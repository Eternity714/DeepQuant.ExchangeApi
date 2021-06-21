using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IKline
    {
        public DateTime DateTime { get; }

        public double High { get; }

        public double Low { get; }

        public double Open { get; }

        public double Close { get; }

        /// <summary>
        /// 交易量
        /// </summary>
        public double Volume { get; }
    }
}
