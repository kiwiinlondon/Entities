
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractResponseHandlerIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        BloombergAlpha = 1
    }
}