using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
        UnitedStates = 53        
    }
}
