using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ClientTradeTypeIds
    {
        [EnumMember]
        Normal = 1,
        [EnumMember]
        Transfer = 2,
        [EnumMember]
        Dividend = 3
    }
}
