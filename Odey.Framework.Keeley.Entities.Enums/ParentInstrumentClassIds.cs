using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ParentInstrumentClassIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Equity =	2,
        [EnumMember]
        FixedIncome =30,
        [EnumMember]
        Future = 35,
        [EnumMember]
        Option = 44,
        [EnumMember]
        CashEquivalent= 53,
        [EnumMember]
        Swap = 60,
        [EnumMember]
        Funds = 72
    }
}
