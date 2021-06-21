using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    /// <summary>
    /// 转账记录
    /// </summary>
    public interface ITransactions
    {
        string Id { get; }

        string Txid { get; }

        DateTime DateTime { get; }

        string AddressFrom { get; }

        string AddressTo { get; }

        /// <summary>
        /// 我的交易地址, 可能是AddressFrom, 也可能是AddressTo
        /// </summary>
        string Address { get; }

        string TagFrom { get; }

        string TagTo { get; }

        string Tag { get; }

        TransactionsSide Side { get; }

        double Amount { get; }

        string Currency { get; }

        TransactionsStatus Status { get; }

        DateTime Updated { get; }

        string Comment { get; }

        ICostFee Fee { get; }


        JToken RawData { get; }
    }
}
