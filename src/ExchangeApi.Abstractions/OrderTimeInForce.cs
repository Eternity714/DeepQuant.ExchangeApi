using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public enum OrderTimeInForce
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// 订单保留在订单簿上，直到它被匹配或取消为止。
        /// </summary>
        GoodTillCancel,

        /// <summary>
        /// 订单必须立即匹配，部分或全部完成，未完成的剩余部分被取消(或整个订单被取消)。
        /// </summary>
        ImmediateOrCancel,

        /// <summary>
        /// 订单必须立即完全成交并关闭，否则整个订单将被取消。
        /// </summary>
        FillOrKill,

        /// <summary>
        /// 订单必须降落在订单簿上，并至少在未填充的状态下停留一段时间
        /// </summary>
        PostOnly,
    }
}
