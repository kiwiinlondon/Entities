using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum FMIndustryIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Fund = 687,
        [EnumMember]
        Unknown = 279,
        [EnumMember]
        UnknownL2 = 712
    }
}
