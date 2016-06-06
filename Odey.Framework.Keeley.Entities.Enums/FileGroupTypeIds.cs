using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum FileGroupTypeIds
    {
        [EnumMember]
        Client=1,
    }
}
