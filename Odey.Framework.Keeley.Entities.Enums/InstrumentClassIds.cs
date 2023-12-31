﻿using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum InstrumentClassIds
    {
        [EnumMember]
        Currency = 3,
        [EnumMember]
        OrdinaryShare = 4,
        [EnumMember]
        ForwardFX = 26,
        [EnumMember]
        ContractForDifference = 27,
        [EnumMember]
        DepositoryReceipt = 28,
        [EnumMember]
        CollectiveInvestmentSchemeOpen = 29,
        [EnumMember]
        CollectiveInvestmentSchemeClosed = 91,
        [EnumMember]
        Bond = 31,
        [EnumMember]
        ConvertibleBond = 32,
        [EnumMember]
        FloatingRateNote = 33,
        [EnumMember]
        GovernmentBondCashProxy = 34,
        [EnumMember]
        EquityIndexFuture = 36,
        [EnumMember]
        CommodityFuture = 37,
        [EnumMember]
        ExchangeTradedFunds = 38,
        [EnumMember]
        PreferenceShare = 39,
        [EnumMember]
        Index = 41,
        [EnumMember]
        Warrant = 42,
        [EnumMember]
        BondFuture = 43,
        [EnumMember]
        EquityOption = 45,
        [EnumMember]
        InterestRateFuture = 46,
        [EnumMember]
        Miscellaneous = 48,
        [EnumMember]
        BankDeposits = 49,
        [EnumMember]
        EquityIndexOption = 50,
        [EnumMember]
        FXFuture = 52,        
        [EnumMember]
        GovtBond = 59,
        [EnumMember]
        OptionOnFuture = 62,        
        [EnumMember]
        RealEstateInvestmentTrust = 66 ,  
        [EnumMember]
        EquityFuture = 78,
        [EnumMember]
        InflationLinkedBond=82,
        [EnumMember]
        Right=88,
        [EnumMember]
        FXOption=87,
        [EnumMember]
        CommodityOption = 89,
        [EnumMember]
        InterestRateSwap = 92,
        [EnumMember]
        CreditSwaption = 93,
        [EnumMember]
        OptionOnBondFuture =95,
        [EnumMember]
        CorporateLoan = 98,
        [EnumMember]
        PhysicalCommoditySpot = 101,
        [EnumMember]
        Repo = 102
    }
}
