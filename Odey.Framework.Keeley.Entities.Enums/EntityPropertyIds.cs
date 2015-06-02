using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]
    public enum EntityPropertyIds
    {
        [EnumMember]
        TradeEvent_FundId = 1,
        [EnumMember]
        TradeEvent_CounterpartyId = 2,
        [EnumMember]
        TradeEvent_TradeDate = 3,
        [EnumMember]
        TradeEvent_SettlementDate = 4,
        [EnumMember]
        TradeEvent_TradeCurrencyId = 5,
        [EnumMember]
        TradeEvent_SettlementCurrencyId = 6,
        [EnumMember]
        TradeEvent_GrossPrice = 7,
        [EnumMember]
        TradeEvent_NetPrice = 8,
        [EnumMember]
        TradeEvent_Quantity = 9,
        [EnumMember]
        TradeEvent_InstrumentMarketID = 10,
        [EnumMember]
        TradeEvent_MatchedStatusId = 11,
        [EnumMember]
        TradeEvent_InputDate = 12,
        [EnumMember]
        TradeEvent_TotalOfCharges = 13,
        [EnumMember]
        TradeEvent_SecurityId = 23,
        [EnumMember]
        TradeEvent_FMOriginalContEventId = 33,
        [EnumMember]
        TradeEvent_NetConsideration = 40,
        [EnumMember]
        TradeEvent_AbsoluteQuantity = 41,
        [EnumMember]
        TradeEvent_BuySellIndicator = 42,
        [EnumMember]
        TradeEvent_IsBuy = 62,
        [EnumMember]
        TradeEvent_GrossConsideration = 85,
        [EnumMember]
        TradeEvent_TotalCommission = 86,
        [EnumMember]
        TradeEvent_TotalOfChargesWithoutCommission = 87,
        [EnumMember]
        TradeEvent_EventId = 113,
        [EnumMember]
        Fund_Name = 36,
        [EnumMember]
        Counterparty_Name = 28,
        [EnumMember]
        Counterparty_LongName = 88,
        [EnumMember]
        Currency_IsoCode = 29,
        [EnumMember]
        InstrumentMarket_Name = 30,
        [EnumMember]
        InstrumentMarket_Sedol = 31,
        [EnumMember]
        InstrumentMarket_InstrumentClassName = 43,
        [EnumMember]
        InstrumentMarket_Isin = 65,
        [EnumMember]
        InstrumentMarket_BloombergTicker = 67,
        [EnumMember]
        InstrumentMarket_BestIdentifier = 84,
        [EnumMember]
        InstrumentClass_Name = 32,
        [EnumMember]
        ExtractEntity_Name = 27,
        [EnumMember]
        ExtractEntity_EntityStatus = 35,
        [EnumMember]
        MatchedStatus_MatchedEstimatedLabel = 39,
        [EnumMember]
        FXTradeEvent_FundId = 45,
        [EnumMember]
        FXTradeEvent_ReceiveCurrencyId = 47,
        [EnumMember]
        FXTradeEvent_PayCurrencyId = 48,
        [EnumMember]
        FXTradeEvent_ReceiveAmount = 49,
        [EnumMember]
        FXTradeEvent_EnteredMultiply = 50,
        [EnumMember]
        FXTradeEvent_CounterpartyId = 51,
        [EnumMember]
        FXTradeEvent_TradeDate = 52,
        [EnumMember]
        FXTradeEvent_MaturityDate = 53,
        [EnumMember]
        FXTradeEvent_FMOriginalContEventId = 54,
        [EnumMember]
        FXTradeEvent_PayAmount = 55,
        [EnumMember]
        FXTradeEvent_TradeCurrencyId = 56,
        [EnumMember]
        FXTradeEvent_ContraCurrencyId = 57,
        [EnumMember]
        FXTradeEvent_TradeCurrencyAmount = 58,
        [EnumMember]
        FXTradeEvent_ContraCurrencyAmount = 59,
        [EnumMember]
        FXTradeEvent_IsBuy = 60,
        [EnumMember]
        FXTradeEvent_Rate = 61,
        [EnumMember]
        FXTradeEvent_BuySellIndicator = 64,
        [EnumMember]
        FXTradeEvent_IsForward = 107,
        [EnumMember]
        FXTradeEvent_MatchedStatusId = 108,
        [EnumMember]
        FXTradeEvent_FXType = 109,
        [EnumMember]
        FXTradeEvent_MaturityDateOnForward = 110,
        [EnumMember]
        MatchingEngineOutput_ReferenceDate = 68,
        [EnumMember]
        MatchingEngineOutput_FMBookId = 69,
        [EnumMember]
        MatchingEngineOutput_FMSecId = 70,
        [EnumMember]
        MatchingEngineOutput_CcyIso = 71,
        [EnumMember]
        MatchingEngineOutput_NetPosition = 72,
        [EnumMember]
        MatchingEngineOutput_Price = 74,
        [EnumMember]
        MatchingEngineOutput_FXRate = 75,
        [EnumMember]
        MatchingEngineOutput_DeltaMarketValue = 76,
        [EnumMember]
        MatchingEngineOutput_MarketValue = 77,
        [EnumMember]
        MatchingEngineOutput_TodayAccrual = 78,
        [EnumMember]
        MatchingEngineOutput_TotalAccrual = 79,
        [EnumMember]
        MatchingEngineOutput_CashIncome = 80,
        [EnumMember]
        MatchingEngineOutput_RealisedFXPNL = 81,
        [EnumMember]
        MatchingEngineOutput_RealisedPricePNL = 82,
        [EnumMember]
        MatchingEngineOutput_TotalPNL = 83,
        [EnumMember]
        MatchingEngineOutput_FMInstClass = 89,
        [EnumMember]
        MatchingEngineOutput_FMFundId = 90,
        [EnumMember]
        MatchingEngineOutput_EZEIdentifier = 101,
        [EnumMember]
        MatchingEngineOutput_MaturityDate = 103,
        [EnumMember]
        MatchingEngineOutput_AccountReference = 104,
        [EnumMember]
        MatchingEngineOutput_Fund = 105,
        [EnumMember]
        MatchingEngineOutput_Quantity = 106,
        [EnumMember]
        Book_Name = 73,
        [EnumMember]
        LegalEntity_LongName = 91,
        [EnumMember]
        LegalEntity_Name = 92,
        [EnumMember]
        Market_BBExchangeCode = 93,
        [EnumMember]
        Issuer_OdeyIndustryId = 100,
        [EnumMember]
        Instrument_InstrumentClassID = 94,
        [EnumMember]
        Instrument_Isin = 95,
        [EnumMember]
        Instrument_IssuerID = 96,
        [EnumMember]
        Instrument_Name = 98,
        [EnumMember]
        Instrument_LongName = 99,
        [EnumMember]
        Instrument_InstrumentID = 117,
        [EnumMember]
        Client_CountryId = 112,
        [EnumMember]
        Client_ClientId = 114,
        [EnumMember]
        Client_Name = 115
    }
}
