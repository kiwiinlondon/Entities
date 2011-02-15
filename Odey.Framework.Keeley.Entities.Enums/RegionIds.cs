using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum RegionIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 1
    }
}
