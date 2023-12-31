﻿using System;
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
        FMOrgIdNew = 45,
        [EnumMember]
        BBCompanyCode =3,
        [EnumMember]
        FMInstClass=4,
        [EnumMember]
        FMInstId=5,
        [EnumMember]
        FMSecIdNew = 44,
        [EnumMember]
        Isin =7,
        [EnumMember]
        Sedol=8,
        [EnumMember]
        BBTicker=9,
        [EnumMember]
        FMStrategy=10,
        [EnumMember]
        FMTradType=11,
        [EnumMember]
        FMContId=12,
        [EnumMember]
        ExternalAccountId = 14,
        [EnumMember]
        FMOriginalContId = 15,
        [EnumMember]
        FMBuySellReasonCode = 16,
        [EnumMember]
        FMPersonId = 17,
        [EnumMember]
        FMOriginalCnevId = 18,
        [EnumMember]
        FMCnevId = 19,
        [EnumMember]
        FMCnevSubType = 20,
        [EnumMember]
        FMChargeTypeCode = 21,
        [EnumMember]
        FMValueSchemeId = 22,
        [EnumMember]
        FMValueSpecId = 61,
        [EnumMember]
        FMSicCode = 24,
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
