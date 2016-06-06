using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Event = 1,
        [EnumMember]
        Reconciliation = 3
    }
}
