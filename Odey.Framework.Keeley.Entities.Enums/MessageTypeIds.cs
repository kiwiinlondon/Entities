using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum MessageTypeIds
    {
        [EnumMember]
        Portfolio,
        [EnumMember]
        AttributionPnl,
        [EnumMember]
        PortfolioRollover
    }
}