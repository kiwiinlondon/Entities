using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractResponseHandlerIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        BloombergAlpha = 1
    }
}