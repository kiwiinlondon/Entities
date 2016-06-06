using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractOutputContainerTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        File = 1,
        [EnumMember]
        String = 2
    }
}
