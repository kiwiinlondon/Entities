using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum FundAnalyticType
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

        [EnumMember]
        FXCost = 8,

        [EnumMember]
        DividendIncome = 9,

        [EnumMember]
        DividendExpense = 10

    }

}