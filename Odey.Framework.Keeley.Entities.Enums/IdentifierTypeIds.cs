using System;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum IdentifierTypeIds
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        IsoCode = 1,
        [EnumMember]
        FMOrgIdOld = 2,
        [EnumMember]        
        FMOrgIdNew = 45,
        [EnumMember]
        BBCompanyCode =3,
        [EnumMember]
        FMInstClassOld=4,
        [EnumMember]
        FMInstClassNew = 49,
        [EnumMember]
        FMInstIdOld=5,
        [EnumMember]
        FMInstIdNew = 50,
        [EnumMember]
        FMSecIdOld=6,
        [EnumMember]
        FMSecIdNew = 44,
        [EnumMember]
        Isin =7,
        [EnumMember]
        Sedol=8,
        [EnumMember]
        BBTicker=9,
        [EnumMember]
        FMStrategyOld=10,
        [EnumMember]
        FMStrategyNew = 55,
        [EnumMember]
        FMTradTypeOld=11,
        [EnumMember]
        FMTradTypeNew = 56,
        [EnumMember]
        FMContId=12,
        [EnumMember]
        ExternalAccountIdOld = 14,
        [EnumMember]
        ExternalAccountIdNew = 62,
        [EnumMember]
        FMOriginalContId = 15,
        [EnumMember]
        FMBuySellReasonCodeOld = 16,
        [EnumMember]
        FMBuySellReasonCodeNew = 58,
        [EnumMember]
        FMPersonIdOld = 17,
        [EnumMember]
        FMPersonIdNew = 53,
        [EnumMember]
        FMOriginalCnevId = 18,
        [EnumMember]
        FMCnevId = 19,
        [EnumMember]
        FMCnevSubTypeOld = 20,
        [EnumMember]
        FMCnevSubTypeNew = 48,
        [EnumMember]
        FMChargeTypeCodeOld = 21,
        [EnumMember]
        FMChargeTypeCodeNew = 59,
        [EnumMember]
        FMValueSchemeIdOld = 22,
        [EnumMember]
        FMValueSchemeIdNew = 60,
        [EnumMember]
        FMValueSpecIdOld = 23,
        [EnumMember]
        FMValueSpecIdNew = 61,
        [EnumMember]
        FMSicCodeOld = 24,
        [EnumMember]
        FMSicCodeNew = 54,
        [EnumMember]
        KeeleyEventId = 25,
        [EnumMember]
        BBGlobalId = 26,
        [EnumMember]
        BBExchangeCode = 27,
        [EnumMember]
        KeeleyName = 29,
        [EnumMember]
        PulseFundCode = 30,
        [EnumMember]
        PulseTradeCode = 31,
        [EnumMember]
        KeeleyEmail = 32,
        [EnumMember]
        KeeleyTradeId = 33,
        [EnumMember]
        GICSCode = 34,
        [EnumMember]
        KeeleyGuid = 35,
        [EnumMember]
        AdministratorId = 36,
        [EnumMember]
        Cusip = 37,
        [EnumMember]
        CustodianId = 38,
        [EnumMember]
        CustodianFamilyId = 39,
        [EnumMember]
        NaceCode = 40,
        [EnumMember]
        KeeleyId = 41,
        [EnumMember]
        KeeleyFinancingId = 42,
        [EnumMember]
        MICCode = 43,
        
      
    }
}
