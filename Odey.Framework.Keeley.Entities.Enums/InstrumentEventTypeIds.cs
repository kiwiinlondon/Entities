using System.Runtime.Serialization;
using TypeLite;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [TsEnum]
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
