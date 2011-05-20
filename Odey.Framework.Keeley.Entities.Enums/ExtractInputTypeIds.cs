using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
        StoredProcedure = 4   
    }
}