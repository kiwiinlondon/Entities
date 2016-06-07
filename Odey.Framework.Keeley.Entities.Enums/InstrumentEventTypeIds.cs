using System;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InstrumentEventTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Dividend = 1,
        [EnumMember]
        ForwardFXMaturity = 3,
        [EnumMember]
        Coupon = 4
    }
}
