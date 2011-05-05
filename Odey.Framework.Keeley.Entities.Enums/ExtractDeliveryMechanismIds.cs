using System.Runtime.Serialization;
namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum  ExtractDeliveryMechanismIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Email = 1
    }
}
