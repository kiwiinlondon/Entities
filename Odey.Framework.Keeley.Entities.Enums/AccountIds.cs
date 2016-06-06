using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum AccountIds
    {
        [EnumMember]
        VT = 108,

        [EnumMember]
        WSEG = 134,

        [EnumMember]
        ITR = 135,
    }
}
