using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum RegionIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1,
        [EnumMember]
        UnitedKingdom = 23,
        [EnumMember]
        NorthAmerica = 24,
        [EnumMember]
        Japan = 25,
        [EnumMember]
        Australasia = 26,
        [EnumMember]
        EuropeExclUK = 27,
        [EnumMember]
        AsiaExclJapan = 28,
        [EnumMember]
        LatinAmerica = 29,
        [EnumMember]
        Africa = 30,
        [EnumMember]
        MiddleEast = 31
    }
}
