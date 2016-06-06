using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum BookIds
    {
        [EnumMember]
        OuarAC = 176,
        [EnumMember]
        ArffAC = 177
    }
}