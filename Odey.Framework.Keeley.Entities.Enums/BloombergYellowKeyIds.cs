using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum BloombergYellowKeyIds
    {
        [EnumMember]
        Equity	= 1,
        [EnumMember]
        GovernmentBond	= 2,
        [EnumMember]
        CorporateBond	= 3,
        [EnumMember]
        PreferenceShare = 4,
        [EnumMember]
        Currency = 5,
        [EnumMember]
        Commodity = 6,
        [EnumMember]
        Index=7
    }
}
