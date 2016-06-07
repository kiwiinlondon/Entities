using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
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
