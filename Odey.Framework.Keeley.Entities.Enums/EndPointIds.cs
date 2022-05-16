using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{

    [DataContract]
    public enum EndPointIds
    {
        [EnumMember]
        PortfolioService = 1,
        [EnumMember]
        FundPerformanceService = 2,
        [EnumMember]
        FocusListService = 3,
        [EnumMember]
        PADealingService = 4,
        [EnumMember]
        InterestRateReturnProcessor = 5,
        [EnumMember]
        PriceCollectionService = 6,
        [EnumMember]
        FMPrice = 7,
        [EnumMember]
        ClientPortfolioService = 8,
        [EnumMember]
        OfficialNAVService = 9

    }
}
