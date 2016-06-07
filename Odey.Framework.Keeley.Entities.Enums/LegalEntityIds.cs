using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum LegalEntityIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 3762
    }
}
