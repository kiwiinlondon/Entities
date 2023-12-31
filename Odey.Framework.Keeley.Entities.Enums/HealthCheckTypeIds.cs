﻿
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

        [EnumMember]
        ANALYTIC_COLLECTED = 8,

        [EnumMember]
        FUND_COST_ENTERED = 9,

        [EnumMember]
        FOCUS_LIST_ISSUER_CHECK = 10,

        [EnumMember]
        ATTRIBUTION_REBUILD_POSITION = 11,

        [EnumMember]
        REPORT_SUBSCRIPTIONS = 12,

        [EnumMember]
        BLOOMBERG_REPORTS_LOADED = 13,

        [EnumMember]
        BLOOMBERG_INDEX_PRICE_CHECK = 14,

        [EnumMember]
        OOF_REFERENCE_ASSET_LOADED = 15,

        [EnumMember]
        SRRI_CLASS_CHECK = 16,

        [EnumMember]
        MESSAGE_QUEUE_CHECK = 17,

        [EnumMember] 
        POSMAN_KEELEY_DAY_RETURN = 18,
        [EnumMember]
        FINANCING_FILES_COLLECTED = 19,
        [EnumMember]
        MISSING_BLOOMBERG_IDENTIFIERS = 20,
        [EnumMember]
        UNMAPPED_FINANCING = 21,
        [EnumMember]
        CLIENT_PLATFORM_BREAKS = 22,
        [EnumMember]
        FUND_PROCESSOR_CHECK = 23
    }
}

