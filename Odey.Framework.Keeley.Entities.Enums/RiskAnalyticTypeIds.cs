using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Enums
{
    [DataContract]

    public enum RiskAnalyticTypeIds
    {
        [Description("Portfolio Total Risk")]
        [EnumMember]
        PortfolioTotalRisk = 1,
        
        [Description("% systematic Portfolio Total Risk")]
        [EnumMember]
        PercentSystematicPortfolioTotalRisk = 2,
        
        [Description("Tracking Error")]
        [EnumMember]
        TrackingError = 3,
        
       [Description("Tracking Variance")]
        [EnumMember]
        TrackingVariance = 4,
        
       [Description("% systematic Tracking Variance")]
        [EnumMember]
        PercentSystematicTrackingVariance = 5,
        
       [Description("Portfolio Beta")]
        [EnumMember]
        PortfolioBeta = 6,
        
       [Description("Unrecognised Stocks, number")]
        [EnumMember]
        UnrecognisedStocksNumber = 7,
        
       [Description("Unrecognised Stocks, % weight")]
        [EnumMember]
        UnrecognisedStocksPercentWeight = 8,
        
       [Description("Illiquid Stocks, number")]
        [EnumMember]
        IlliquidStocksNumber = 9,
        
       [Description("Illiquid Stocks, % weight")]
        [EnumMember]
        IlliquidStocksPercentWeight = 10,
        
        [Description("Excluded Stocks, number")]
        [EnumMember]
        ExcludedStocksNumber = 11,
        
        [Description("Weights > 5%, number")]
        [EnumMember]
        WeightsGreater5PercentNumber = 12,
        
        [Description("Weights > 10%, number")]
        [EnumMember]
        WeightsGreater10PercentNumber = 13,
        
        [Description("Weights > 20%, number")]
        [EnumMember]
        WeightsGreater20PercentNumber = 14,
        
        [Description("Weights > 5%, % weight")]
        [EnumMember]
        WeightsGreater5PercentWeight = 15,
        
        [Description("Weights > 10%, % weight")]
        [EnumMember]
        WeightsGreater10PercentWeight = 16,
        
        [Description("Weights > 20%, % weight")]
        [EnumMember]
        WeightsGreater20PercentWeight = 17,
        
        [Description("Port Var with Deriv - Primary")]
        [EnumMember]
        PortVarWithDerivPrimary = 18,
        
        [Description("Implied Leverage, Primary Settings")]
        [EnumMember]
        ImpliedLeveragePrimarySettings = 19,
        
        [Description("Cumulative No. of Shortfalls")]
        [EnumMember]
        CumulativeNumberOfShortfalls = 20,
        
        [Description("January 1974 Oil Price shock")]
        [EnumMember]
        January1974OilPriceShock = 21,
        
        [Description("1981 Recession")]
        [EnumMember]
        Recession1981 = 22,
        
        [Description("October 1987 Stock Market Crash")]
        [EnumMember]
        October1987StockMarketCrash = 23,
        
        [Description("1990 Recession")]
        [EnumMember]
        Recession1990 = 24,
        
        [Description("Sep-Dec 1992 Sterling Devaluation")]
        [EnumMember]
        SepDec1992SterlingDevaluation = 25,
        
        [Description("July 1997 - Jan 1998 Asia Crisis")]
        [EnumMember]
        July1997Jan1998AsiaCrisis = 26,
        
        [Description("Aug 1998 Russian crisis, LTCM")]
        [EnumMember]
        Aug1998RussianCrisisLTCM = 27,
        
        [Description("Sep 2001 September 11th")]
        [EnumMember]
        Sep2001September11Th = 28,
        
        [Description("Scenario: European recession")]
        [EnumMember]
        ScenarioEuropeanRecession = 29,
        
        [Description("Scenario: US recession")]
        [EnumMember]
        ScenarioUSRecession = 30,
        
       [Description("Index VaR, Primary Settings")]
        [EnumMember]
        IndexVaRPrimarySettings = 31,
        
       [Description("Port Var with Deriv - Secondary")]
        [EnumMember]
        PortVarWithDerivSecondary = 32,
        
       [Description("Index VaR, Secondary Settings")]
        [EnumMember]
        IndexVaRSecondarySettings = 33,
        
       [Description("Illiquid Assets")]
        [EnumMember]
        IlliquidAssets = 34,
        
       [Description("Arab spring part 2 - M.E. revolutions")]
        [EnumMember]
        ArabSpringPart2MErevolutions = 35,
        
       [Description("Bearish Flattening 75bps")]
        [EnumMember]
        BearishFlattening75bps = 36,
        
       [Description("Bearish Steepening 75bps")]
        [EnumMember]
        BearishSteepening75bps = 37,
        
       [Description("Big rise global inflation expectations")]
        [EnumMember]
        BigRiseGlobalInflationExpectations = 38,
        
       [Description("Bullish Flattening -75bps")]
        [EnumMember]
        BullishFlattening75bps = 39,
        
       [Description("Bullish Steepening -75bps")]
        [EnumMember]
        BullishSteepening75bps = 40,
        
       [Description("China recession")]
        [EnumMember]
        ChinaRecession = 41,
        
       [Description("Convex Butterfly 25bps")]
        [EnumMember]
        ConvexButterfly25bps = 42,
        
       [Description("Ceiling, QE3, flight out USD & USTs")]
        [EnumMember]
        CeilingQE3FlightOutUSDAndUST = 43,
        
       [Description("Germ/Holl leave EUR&form NordEuro")]
        [EnumMember]
        Germ_HollLeaveEURAndFormNordEuro = 44,
        
       [Description("Inverse Butterfly -25bps")]
        [EnumMember]
        InverseButterfly25bps = 45,
        
       [Description("Lehman Sep08 (1m horizon)")]
        [EnumMember]
        LehmanSep08_1mHorizon = 46,
        
       [Description("Lehman Sep08 (3m horizon)")]
        [EnumMember]
        LehmanSep08_3mHorizon = 47,
        
       [Description("Robust, non-inflationary growth")]
        [EnumMember]
        RobustNonInflationaryGrowth = 48,
        
       [Description("S-T spike in energy, metals, agri")]
        [EnumMember]
        S_TSpikeInEnergyMetalsAgri = 49,

        [Description("Spanish sovereign contagion")]
        [EnumMember]
        SpanishSovereignContagion = 50,

        [Description("USD Appreciates by 10%")]
        [EnumMember]
        USDAppreciatesBy10Percent = 51,
    }
}
