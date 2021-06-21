using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface ILedger
    {
        string Id { get; }

        LedgerDirection Direction { get; }

        string Account { get; }

        /// <summary>
        /// trade、transaction等的id
        /// </summary>
        string ReferenceId { get; }

        /// <summary>
        /// 对应的账号id, 如果有
        /// </summary>
        string ReferenceAccount { get; }

        LedgerType Type { get; }

        string Currency { get; }

        double Amount { get; }

        DateTime DateTime { get; }

        double Before { get; }

        double After { get; }

        LedgerStatus Status { get; }

        ICostFee Fee { get; }

        JToken RawData { get; }
    }
}
