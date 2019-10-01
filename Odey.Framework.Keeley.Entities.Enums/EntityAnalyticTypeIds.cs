using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityAnalyticTypeIds
    {
        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        Fees = 1,

        [EnumMember]
        AnnualFees = Fees | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargeDebitCash = 2,

        [EnumMember]
        AnnualFinancingChargeDebitCash = FinancingChargeDebitCash | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargeCreditCash = 3,

        [EnumMember]
        AnnualFinancingChargeCreditCash = FinancingChargeCreditCash | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargeLongSwap = 4,

        [EnumMember]
        AnnualFinancingChargeLongSwap = FinancingChargeLongSwap | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargeShortSwap = 5,

        [EnumMember]
        AnnualFinancingChargeShortSwap = FinancingChargeShortSwap | 1024,
        
        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        TransactionChargeFutures = 6,

        [EnumMember]
        AnnualTransactionChargeFutures = TransactionChargeFutures | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        TransactionChargeEquity = 7,

        [EnumMember]
        AnnualTransactionChargeEquity = TransactionChargeEquity | 1024,

        /// <summary>
        /// Cost of Carry Analysis by Fund
        /// SubEntityId is CurrencyId of the FX currency that the cost is for
        /// </summary>
        [EnumMember]
        FXCost = 8,

        [EnumMember]
        AnnualFXCost = FXCost | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        DividendIncome = 9,

        [EnumMember]
        AnnualDividendIncome = DividendIncome | 1024,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        DividendExpense = 10,

        [EnumMember]
        AnnualDividendExpense = DividendExpense | 1024,

        /// <summary>
        /// Fees to Street Analysis By Counterparty
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        PrimeBrokerFee = 11,

        /// <summary>
        /// Fees to Street Analysis By Counterparty
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        BrokerFuturesAndOptions = 12,

        /// <summary>
        /// Trading Cost Analysis By Manager
        /// </summary>
        [EnumMember]
        IntervalVWAP = 13,

        /// <summary>
        /// Trading Cost Analysis By Manager
        /// </summary>
        [EnumMember]
        Slippage = 14,

        /// <summary>
        /// Trading Cost Analysis By Manager
        /// </summary>
        [EnumMember]
        MarketVolume = 15,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargeStockLoan = 16,

        /// <summary>
        /// Cost of Carry Analysis By Fund
        /// </summary>
        [EnumMember]
        FinancingChargePreBorrow = 17,

        /// <summary>
        /// Fees to Street Analysis By Counterparty
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        BrokerFXTradingCost = 18,

        /// <summary>
        /// Fees to Street Analysis By Counterparty
        /// Payout from CSA pot to broker. Entered Quarterly
        /// </summary>
        [EnumMember]
        BrokerVotedResearch = 19,
        
        [EnumMember]
        TransactionChargeFxRoll = 20,
        
        [EnumMember]
        OngoingChargesResearch = 21,
        
        [EnumMember]
        FixedIncomeCarry = 22,

        /// <summary>
        /// Used to indicate an annualised prediction of one of the above values
        /// </summary>
        [EnumMember]
        AnnualisedPredictionModifier = 1024,
    }

}