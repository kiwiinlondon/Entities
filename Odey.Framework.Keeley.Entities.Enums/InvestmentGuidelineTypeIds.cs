using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InvestmentGuidelineTypeIds
    {
        [EnumMember]
        EquitiesCommodities = 1,
        [EnumMember]
        Equities = 2,
        [EnumMember]
        GovernmentBonds = 3,
        [EnumMember]
        CorporateBonds = 4,
        [EnumMember]
        ActiveCurrency = 5,
        [EnumMember]
        Commodities = 6,
        [EnumMember]
        AIFExposure = 7,
        [EnumMember]
        DebtIssuanceOfSingleIssuer = 8,
        [EnumMember]
        DepositsAtOneInstitution = 9,
        [EnumMember]
        MoneyMarketIssuanceOfSingleIssuer = 10,
        [EnumMember]
        NonVotingSharesOfSingleIssuer = 11,
        [EnumMember]
        UnitsOfCIS = 12,
        [EnumMember]
        AggregateBorrowings = 13,
        [EnumMember]
        NonInvestmentGuidelineAssetClasses = 15,
        [EnumMember]
        ExposureToSingleCounterparty =	16,
        [EnumMember]
        OTCCounterpartyExposure	=17,
        [EnumMember]
        SingleIssuerExposure = 18,
        [EnumMember]
        SumOfExposuresGreaterFivePercent =	19,
        [EnumMember]
        VaR20d99Percent	= 20,
        [EnumMember]
        ShortSingleIssuerExposure = 21,
        [EnumMember]
        LongSingleIssuerExposure = 22,
        [EnumMember]
        ChinaASharesExposure = 23,
        [EnumMember]
        NonEuropeanExposure = 24,
        [EnumMember]
        SingleGovernmentBondIssue=	25,
        [EnumMember]
        GovernmentBondExposure = 26,
        [EnumMember]
        GovernmentBondCountExposureGreater35 = 27
    }
}
