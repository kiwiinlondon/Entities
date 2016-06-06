using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum CountryIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        GreatBritain = 62,
        [EnumMember]
        Ireland = 56,
        [EnumMember]
        UnitedStates = 53,        
        [EnumMember]
        Australia = 55    
    }
}
