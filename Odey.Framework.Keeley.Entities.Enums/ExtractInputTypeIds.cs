using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractInputTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        ExtractEntity = 1,
        [EnumMember]
        MatchingEngineOutput = 2,       
        [EnumMember]
        StoredProcedure = 4,   
        [EnumMember]
        Portfolio = 5 ,
        [EnumMember]
        FXPositions = 6,
        [EnumMember]
        ThreeWayNavOutput=7,
        [EnumMember]
        PerformanceWithAUM=8
    }
}