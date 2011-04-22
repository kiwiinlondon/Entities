using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum ExtractTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Event = 1
    }
}
