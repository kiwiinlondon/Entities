using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum IndustryClassificationIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        FundManager = 1,
        [EnumMember]
        Odey = 2,
        [EnumMember]
        GICS = 3
    }
}
