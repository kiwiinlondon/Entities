using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractOutputTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        CSV = 1
    }
}