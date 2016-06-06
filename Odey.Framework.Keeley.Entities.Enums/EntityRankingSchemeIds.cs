using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum EntityRankingSchemeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Default=1,
        [EnumMember]
        CFD=2,
        [EnumMember]
        TreasuryBonds=3,
        [EnumMember]
        FundValuation=6,
        [EnumMember]
        Options = 10,
        [EnumMember]
        AustralianFutures = 12,
        [EnumMember]
        AustralianGovtBonds = 13,
    }
}
