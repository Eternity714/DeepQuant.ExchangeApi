using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IPosition
    {
        string PositionId { get; }

        string Symbol { get; }

        DateTime DateTime { get; }

        /// <summary>
        /// whether or not the position is isolated, as opposed to cross where margin is added automatically
        /// </summary>
        bool Isolated { get; }

        /// <summary>
        /// whether or not the position is hedged, i.e. if trading in the opposite direction will close this position or make a new one
        /// </summary>
        bool Hedged { get; }

        PositionSide Side { get; }

        /// <summary>
        /// 合约数量
        /// </summary>
        int Contracts { get; }

        /// <summary>
        /// 交易单价
        /// </summary>
        double Price { get; }

        /// <summary>
        /// 标记价格
        /// </summary>
        double MarkPrice { get; }

        /// <summary>
        /// 合约价值
        /// </summary>
        double Notional { get; }

        /// <summary>
        /// 杠杆率
        /// </summary>
        int Leverage { get; }

        /// <summary>
        /// 已实现盈亏
        /// </summary>
        double RealizedPnl { get; }

        /// <summary>
        /// 未实现盈亏
        /// </summary>
        double UnrealizedPnl { get; }

        /// <summary>
        /// 盈亏总额，可以是负数
        /// </summary>
        double Pnl { get; }

        /// <summary>
        /// 可能亏损的最大抵押物价值, 受Pnl影响
        /// </summary>
        double Collateral { get; }

        /// <summary>
        /// 当前抵押物价值
        /// </summary>
        double InitialMargin { get; }

        /// <summary>
        /// 最少抵押物价值
        /// </summary>
        double MaintenanceMargin { get; }

        /// <summary>
        /// 当前抵押物价值占比, InitialMargin / Notional
        /// </summary>
        double InitialMarginPercentage { get; }

        /// <summary>
        /// 最少抵押物价值占比, MaintenanceMarginPercentage / Notional
        /// </summary>
        double MaintenanceMarginPercentage { get; }

        /// <summary>
        /// 强平价格
        /// </summary>
        double LiquidationPrice { get; }

        PositionStatus Status { get; }

        JToken RawData { get; }
    }
}
