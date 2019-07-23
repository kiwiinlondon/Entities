using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum TaskIds
    {
        [EnumMember]
        RollPrices = 1,
        [EnumMember]
        RollFXRates = 2,
        [EnumMember]
        RollAnalytics = 3,
        [EnumMember]
        RollRiskAnalytics = 4,
        [EnumMember]
        RollIssuerAnalytics = 5,
        [EnumMember]
        RollBetas = 6,
        [EnumMember]
        RollPortfolio = 7,
        [EnumMember]
        RollAttributionNavs = 8,
        [EnumMember]
        RollAttributionPNLs = 9,
        [EnumMember]
        RollExposure = 10,
        [EnumMember]
        RollNewValuationAttributionPnl = 11,
        [EnumMember]
        RollCarryAccruals = 12,
        [EnumMember]
        RollOfficialNavs = 13,
        [EnumMember]
        RollClientPortfolio = 14,
        [EnumMember]
        RollInterestRateReturns = 15,
        [EnumMember]
        RollFocusList = 16,
        [EnumMember]
        RollPADealingBalances = 17,
        [EnumMember]
        ProcessFutureEvents = 18,
        [EnumMember]
        SendRolloverCompleteMessageToCache = 19,
        [EnumMember]
        Rollover = 20,
        [EnumMember]
        RunKeeleyTradeBridge = 21
    }
}
