using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EventTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        TradeEvent = 1,
        [EnumMember]
        InstrumentEvent = 2,
        [EnumMember]
        CapitalEvent = 3,
        [EnumMember]
        FXTradeEvent = 4,
        [EnumMember]
        InternalAllocation = 5,
        [EnumMember]
        TransferEvent = 13
    }
}
