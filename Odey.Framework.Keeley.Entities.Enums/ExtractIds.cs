using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ExtractIds
    {
        [EnumMember]
        ClientReconciliation = 16
    }
}
