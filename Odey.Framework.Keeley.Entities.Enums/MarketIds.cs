using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MarketIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Unknown = 3762,
        [EnumMember]
        LondonStockExchange = 3612,
        [EnumMember]
        SydneyFuturesExchange = 6785,

    }
}