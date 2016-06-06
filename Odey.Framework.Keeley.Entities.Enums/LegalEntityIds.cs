using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum LegalEntityIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 3762
    }
}
