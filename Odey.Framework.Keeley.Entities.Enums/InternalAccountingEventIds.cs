using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InternalAccountingEventIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        ConvertToUnderlyer=1,
        [EnumMember]
        RollToRealisePNL=2,
        [EnumMember]
        Other=3
    }
}
