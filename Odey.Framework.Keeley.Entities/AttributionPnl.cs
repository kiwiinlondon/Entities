//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Odey.Framework.Keeley.Entities
{
    using System;
    using System.Collections.Generic;
    
    using System.Runtime.Serialization;
    [DataContract(IsReference = true)]
    public partial class AttributionPnl
    {
    	[DataMember]
        public int AttributionPnlId { get; set; }
    	[DataMember]
        public int PortfolioId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public int PositionID { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int AttributionSourceId { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public decimal NetPosition { get; set; }
    	[DataMember]
        public bool IsNetPositionLong { get; set; }
    	[DataMember]
        public bool IsExposureLong { get; set; }
    	[DataMember]
        public decimal Exposure { get; set; }
    	[DataMember]
        public decimal ExposureDelta { get; set; }
    	[DataMember]
        public decimal TodayPricePnl { get; set; }
    	[DataMember]
        public decimal TodayFxPnl { get; set; }
    	[DataMember]
        public decimal TodayCarryPnl { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOtherPnl { get; set; }
    	[DataMember]
        public int PnlTypeId { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public Nullable<int> PriceId { get; set; }
    	[DataMember]
        public decimal PriceToPositionFXRate { get; set; }
    	[DataMember]
        public Nullable<int> PriceToPositionFXRateId { get; set; }
    	[DataMember]
        public decimal FXRate { get; set; }
    	[DataMember]
        public Nullable<int> FXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaShortTerm { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaLongTerm { get; set; }
    	[DataMember]
        public decimal TodayRealisedFXPnl { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePnl { get; set; }
    	[DataMember]
        public decimal TodayCashBenefit { get; set; }
    	[DataMember]
        public decimal NotionalCost { get; set; }
    	[DataMember]
        public Nullable<int> MarketDataStatus { get; set; }
    	[DataMember]
        public Nullable<int> BetaShortTermId { get; set; }
    	[DataMember]
        public Nullable<int> BetaLongTermId { get; set; }
    	[DataMember]
        public Nullable<decimal> NavFXRate { get; set; }
    	[DataMember]
        public Nullable<decimal> PricePnl { get; set; }
    	[DataMember]
        public Nullable<decimal> FXPnl { get; set; }
    	[DataMember]
        public decimal MaxExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ForwardFXRate { get; set; }
    	[DataMember]
        public Nullable<int> ForwardFXRateId { get; set; }
    	[DataMember]
        public decimal OriginalNotionalCost { get; set; }
    	[DataMember]
        public decimal CostPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> AllinAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> AllInRate { get; set; }
    	[DataMember]
        public Nullable<decimal> SettledNotionalCost { get; set; }
    	[DataMember]
        public Nullable<decimal> SettledNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> SettledExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> SettledMarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> FinancingAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> BorrowAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> OverborrowNotional { get; set; }
    	[DataMember]
        public Nullable<decimal> OverborrowAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> MarginInterest { get; set; }
    	[DataMember]
        public Nullable<decimal> CashInterest { get; set; }
    	[DataMember]
        public Nullable<decimal> FinancingRate { get; set; }
    	[DataMember]
        public Nullable<decimal> BorrowRate { get; set; }
    	[DataMember]
        public Nullable<decimal> OverborrowRate { get; set; }
    	[DataMember]
        public Nullable<decimal> OverborrowUnits { get; set; }
    	[DataMember]
        public Nullable<decimal> Commission { get; set; }
    	[DataMember]
        public Nullable<decimal> Redemptions { get; set; }
    	[DataMember]
        public Nullable<decimal> Subscriptions { get; set; }
    	[DataMember]
        public Nullable<decimal> FuturesClearing { get; set; }
    	[DataMember]
        public Nullable<decimal> OtherExpense { get; set; }
    	[DataMember]
        public Nullable<decimal> ConsiderationBuy { get; set; }
    	[DataMember]
        public Nullable<decimal> ConsiderationSell { get; set; }
    	[DataMember]
        public Nullable<int> TradeCount { get; set; }
    	[DataMember]
        public Nullable<int> CounterpartyId { get; set; }
    	[DataMember]
        public decimal BookNav { get; set; }
    	[DataMember]
        public decimal FundNav { get; set; }
    	[DataMember]
        public decimal OpeningNav { get; set; }
    	[DataMember]
        public decimal KeeleyFundNav { get; set; }
    	[DataMember]
        public Nullable<int> EURFXRateId { get; set; }
    	[DataMember]
        public decimal EURFXRate { get; set; }
    	[DataMember]
        public Nullable<int> USDFXRateId { get; set; }
    	[DataMember]
        public decimal USDFXRate { get; set; }
    	[DataMember]
        public Nullable<int> GBPFXRateId { get; set; }
    	[DataMember]
        public decimal GBPFXRate { get; set; }
    	[DataMember]
        public Nullable<int> VolumeId { get; set; }
    	[DataMember]
        public Nullable<decimal> Volume { get; set; }
    	[DataMember]
        public Nullable<int> SharesOutstandingId { get; set; }
    	[DataMember]
        public Nullable<decimal> SharesOutstanding { get; set; }
    	[DataMember]
        public Nullable<int> HedgeRatioId { get; set; }
    	[DataMember]
        public Nullable<decimal> HedgeRatio { get; set; }
    	[DataMember]
        public Nullable<int> MarketCapitalisationId { get; set; }
    	[DataMember]
        public Nullable<decimal> MarketCapitalisation { get; set; }
    	[DataMember]
        public Nullable<int> ADRUnderlyerVolumeId { get; set; }
    	[DataMember]
        public Nullable<decimal> ADRUnderlyerVolume { get; set; }
    	[DataMember]
        public decimal PercentageOfFund { get; set; }
    	[DataMember]
        public bool KeeleyIsMaster { get; set; }
    	[DataMember]
        public Nullable<int> NavFXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> Expense { get; set; }
    	[DataMember]
        public Nullable<decimal> AllInAccrualOffset { get; set; }
    	[DataMember]
        public Nullable<decimal> CashInterestCredit { get; set; }
    	[DataMember]
        public Nullable<decimal> RehypothecationEarning { get; set; }
    	[DataMember]
        public Nullable<decimal> MarginRequirement { get; set; }
    	[DataMember]
        public Nullable<decimal> CashInterestDebit { get; set; }
    	[DataMember]
        public Nullable<decimal> Slippage { get; set; }
    	[DataMember]
        public Nullable<decimal> RehypothecationValue { get; set; }
    	[DataMember]
        public Nullable<decimal> RehypothecationUnits { get; set; }
    	[DataMember]
        public Nullable<decimal> LegalExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> MarginRequirementRate { get; set; }
    	[DataMember]
        public decimal PositionSize { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaSixMonth { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaOneYear { get; set; }
    	[DataMember]
        public Nullable<int> BetaOneYearId { get; set; }
    	[DataMember]
        public Nullable<int> BetaSixMonthId { get; set; }
    	[DataMember]
        public Nullable<decimal> LoanedPortfolioUnits { get; set; }
    	[DataMember]
        public Nullable<decimal> LoanedPortfolioNotional { get; set; }
    	[DataMember]
        public Nullable<decimal> LoanedPortfolioGrossFee { get; set; }
    	[DataMember]
        public Nullable<decimal> LoanedPortfolioRate { get; set; }
    	[DataMember]
        public Nullable<decimal> RepoNotional { get; set; }
    	[DataMember]
        public Nullable<decimal> RepoNotionalWithHaircut { get; set; }
    	[DataMember]
        public Nullable<decimal> NumberOfBondsInIssue { get; set; }
    	[DataMember]
        public Nullable<int> NumberOfBondsInIssueId { get; set; }
    
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual Portfolio Portfolio { get; set; }
        [DataMember]
        public virtual LegalEntity LegalEntity { get; set; }
    }
}
