using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum ApplicationUserIds
    {
        [EnumMember]
        Pulse = 50,
        [EnumMember]
        KeeyeyServiceUser = 54
    }
}
