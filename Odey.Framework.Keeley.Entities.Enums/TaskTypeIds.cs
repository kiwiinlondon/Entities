using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{

    [DataContract]
    public enum TaskTypeIds
    {
        [EnumMember]
        PortfolioService = 1,
        [EnumMember]
        PriceService = 2,
        [EnumMember]
        FXRateService = 3,
        [EnumMember]
        AnalyticService = 4,
        [EnumMember]
        BetaService = 5,
        [EnumMember]
        OfficialNavService = 6,
        [EnumMember]
        ClientPortfolioService = 7,
        [EnumMember]
        FocusListService = 8,
        [EnumMember]
        PADealingService = 9
    }
}

