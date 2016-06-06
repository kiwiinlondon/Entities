using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
    [DataContract]
    public enum DayCountConventionIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        ActAct=1,
        [EnumMember]
        Thirty360=2,
        [EnumMember]
        ThirtyE360=3,
        [EnumMember]
        ACT360=4,
        [EnumMember]
        ACT365=5
    }    
}
