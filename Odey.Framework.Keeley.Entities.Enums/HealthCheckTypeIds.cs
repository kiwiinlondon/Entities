
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
 [DataContract]
    public enum HealthCheckTypeIds
    {
        [EnumMember]
        FM_TRADE_BRIDGE_RAN = 1,

        [EnumMember]
        INTRANET_PING = 2,
    }
}

