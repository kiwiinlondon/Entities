using System.ComponentModel;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum DerivedAssetClassIds
    {
        [Description("Equity")]
        [EnumMember]
        Equity = 1,

        [Description("Corporate Debt")]
        [EnumMember]
        CorporateDebt = 2,

        [Description("Commodity")]
        [EnumMember]
        Commodity = 3,

        [Description("Government Bond")]
        [EnumMember]
        GovernmentBond = 6,

        [Description("Cash")]
        [EnumMember]
        Cash = 7,

        [Description("Foreign Exchange")]
        [EnumMember]
        ForeignExchange = 9,

        [Description("Other")]
        [EnumMember]
        Other = 10,

        [Description("Interest Rate")]
        [EnumMember]
        InterestRate = 11,

        [Description("Credit")]
        [EnumMember]
        Credit = 12,
    }
}
