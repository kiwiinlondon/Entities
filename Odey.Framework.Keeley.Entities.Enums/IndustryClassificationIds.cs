using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum IndustryClassificationIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        FundManager = 1
    }
}
