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

        [Description("Bond")]
        [EnumMember]
        Bond = 2,

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
        ForeignExchange = 9,

        [Description("Other")]
        Other = 10,

        [Description("Interest Rate")]
        InterestRate = 11,
    }
}
