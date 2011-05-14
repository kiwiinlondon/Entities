using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractDeliveryTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Email = 1
    }
}