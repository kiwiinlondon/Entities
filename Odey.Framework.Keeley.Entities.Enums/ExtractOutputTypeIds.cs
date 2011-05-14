using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractOutputTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        CSV = 1,
        [EnumMember]
        Delimited = 2,
        [EnumMember]
        HTML = 3
    }
}