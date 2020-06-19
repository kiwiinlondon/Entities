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
        UnitedStates = 53,
        [EnumMember]
        Australia = 55,
        [EnumMember]
        China = 57,
        [EnumMember]
        HongKong = 58,
        [EnumMember]
        Canada = 68,
        [EnumMember]
        Argentina = 111
    }
}
