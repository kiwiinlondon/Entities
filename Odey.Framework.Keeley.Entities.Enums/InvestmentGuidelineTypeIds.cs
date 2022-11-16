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
        AggregateBorrowings = 13
    }
}
