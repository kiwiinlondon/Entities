using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityAnalyticTypeIds
    {
        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        Fees = 1,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        FinancingChargeDebitCash = 2,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        FinancingChargeCreditCash = 3,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        FinancingChargeLongSwap = 4,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        FinancingChargeShortSwap = 5,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        TransactionChargeFutures = 6,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        TransactionChargeEquity = 7,

        /// <summary>
        /// Cost of Carry Analysis
        /// SubEntityId is CurrencyId of the FX currency that the cost is for
        /// </summary>
        [EnumMember]
        FXCost = 8,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        DividendIncome = 9,

        /// <summary>
        /// Cost of Carry Analysis
        /// </summary>
        [EnumMember]
        DividendExpense = 10,

        /// <summary>
        /// Fees to Street Analysis
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        PrimeBrokerFee = 11,

        /// <summary>
        /// Fees to Street Analysis
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        BrokerFuturesAndOptions = 12,

        /// <summary>
        /// Trading Cost Analyis
        /// </summary>
        [EnumMember]
        IntervalVWAP = 13,

        /// <summary>
        /// Trading Cost Analysis
        /// </summary>
        [EnumMember]
        Slippage = 14,

        /// <summary>
        /// Trading Cost Analysis
        /// </summary>
        [EnumMember]
        MarketVolume = 15,
    }

}