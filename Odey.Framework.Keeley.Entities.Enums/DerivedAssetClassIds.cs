using System.ComponentModel;
using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum DerivedAssetClassIds
    {
        [Description("Equity")]
        [EnumMember]
        Equity = 1,

        [Description("Corporate Bond")]
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
        [EnumMember]
        ForeignExchange = 9,

        [Description("Other")]
        [EnumMember]
        Other = 10,

        [Description("Interest Rate")]
        [EnumMember]
        InterestRate = 11,
    }
}
