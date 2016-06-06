using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum MatchedStatusIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Matched = 1,
        [EnumMember]
        Notified = 2,
        [EnumMember]
        Rejected = 3,
        [EnumMember]
        Broken = 4,
        [EnumMember]
        NotApplicable = 5
    }
}
