using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
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
        HTML = 3,
        [EnumMember]
        FixedWidth = 4
    }
}