using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ClientIds
    {
        [EnumMember]
        Dummy = 9706,
        [EnumMember]
        Staff = 7425
    }
}
