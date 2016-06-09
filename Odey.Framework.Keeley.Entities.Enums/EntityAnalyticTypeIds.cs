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
        [EnumMember]
        Fees = 1,

        [EnumMember]
        FinancingChargeDebitCash = 2,

        [EnumMember]
        FinancingChargeCreditCash = 3,

        [EnumMember]
        FinancingChargeLongSwap = 4,

        [EnumMember]
        FinancingChargeShortSwap = 5,

        [EnumMember]
        TransactionChargeFutures = 6,

        [EnumMember]
        TransactionChargeEquity = 7,

        /// <summary>
        /// SubEntityId is CurrencyId of the FX currency that the cost is for
        /// </summary>
        [EnumMember]
        FXCost = 8,

        [EnumMember]
        DividendIncome = 9,

        [EnumMember]
        DividendExpense = 10,

        /// <summary>
        /// SubEntityId is CurrencyId of the entered value (usually USD)
        /// </summary>
        [EnumMember]
        PrimeBrokerFee = 11,
    }

}