using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum IndustryIds
    {
        [EnumMember]
        GICSUnclassifiedSector = 846,

        [EnumMember]
        GICSUnclassifiedIndustryGroup = 847,

        [EnumMember]
        GICSUnclassifiedIndustry = 848,

        [EnumMember]
        GICSUnclassifiedSubIndustry = 849,
    }
}
