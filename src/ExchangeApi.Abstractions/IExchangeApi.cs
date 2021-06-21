using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExchangeApi
{
    public interface IExchangeApi
    {
        Task<IEnumerable<IMarket>> GetMarkets();

        Task<IEnumerable<ICurrency>> GetCurrencies();

        Task<ITicker> GetTicker();

        Task<IEnumerable<ITicker>> GetTickers();

        Task<IEnumerable<IKline>> GetKlines();

        Task GetStatus();

        Task<IEnumerable<ITrade>> GetTrades();

        Task<IEnumerable<IBalance>> GetBalance();

        Task<string> CreateOrder();

        Task CancelOrder();

        Task<IOrder> GetOrder(string id);

        Task<IEnumerable<IOrder>> GetOrders();

        Task<IEnumerable<IOrder>> GetOpenOrders();

        Task<IEnumerable<IOrder>> GetClosedOrders();

        Task<IEnumerable<IMyTrade>> GetMyTrades();

        Task<IEnumerable<IMyTrade>> GetOrderTrades();

        Task<IEnumerable<IPosition>> GetPositions();

        Task<IEnumerable<IPosition>> GetOpenPositions();

        Task<IAddress> GetDepositAddress();

        Task Deposit();

        Task Withdraw();

        Task<IEnumerable<ITransactions>> GetDeposits();

        Task<IEnumerable<ITransactions>> GetWithdrawals();

        Task<IEnumerable<ITransactions>> GetTransactions();

        Task<IFeeCollection> GetFees();

        /// <summary>
        /// 获取交易费率
        /// </summary>
        /// <returns></returns>
        Task<ITradingFeeCollection> GetTradingFees();

        /// <summary>
        /// 获取转账费率
        /// </summary>
        /// <returns></returns>
        Task<IFundingFeeCollection> GetFundingFees();

        /// <summary>
        /// 分类账本
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ILedger>> GetLedger();

        //Task<JToken> RawCall(string funcName, JToken data);

        void WatchTicker();

        void WatchTickers();

        void WatchOrderBook();

        void WatchKlines();

        void WatchStatus();

        void WatchTrades();

        void WatchBalance();

        void WatchCreateOrder();

        void WatchCancelOrder();

        void WatchOrder();

        void WatchOrders();

        void WatchOpenOrders();

        void WatchClosedOrders();

        void WatchMyTrades();

        void WatchDeposit();

        void WatchWithdraw();
    }
}
