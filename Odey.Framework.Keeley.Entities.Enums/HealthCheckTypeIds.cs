
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

        [EnumMember]
        FILE_COLLECTED_CHECK = 3,

        [EnumMember]
        MISSING_BETA_VALUE = 4,

        [EnumMember]
        FX_COLLECTED = 5,

        [EnumMember]
        CLIENT_FILES_COLLECTED = 6,

        [EnumMember]
        PRICE_COLLECTED = 7,
    }
}

