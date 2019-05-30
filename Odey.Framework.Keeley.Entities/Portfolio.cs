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
    public partial class Portfolio
    {
    	
        public Portfolio()
        {
            this.Exposures = new List<Exposure>();
            this.AttributionPnls = new List<AttributionPnl>();
        }
    
    	[DataMember]
        public int PortfolioId { get; set; }
    	[DataMember]
        public int PositionId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public decimal NetPosition { get; set; }
    	[DataMember]
        public decimal NetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal NetCostBookCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetPostionChange { get; set; }
    	[DataMember]
        public decimal TodayDeltaNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal TodayDeltaNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public decimal TodayCashBenefit { get; set; }
    	[DataMember]
        public decimal TodayCashBenefitBookCurrency { get; set; }
    	[DataMember]
        public decimal TodayAccrual { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePnl { get; set; }
    	[DataMember]
        public decimal TodayRealisedFxPnl { get; set; }
    	[DataMember]
        public decimal TotalAccrual { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePnlBookCurrency { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public Nullable<int> PriceId { get; set; }
    	[DataMember]
        public decimal FXRate { get; set; }
    	[DataMember]
        public Nullable<int> FXRateId { get; set; }
    	[DataMember]
        public decimal DeltaMarketValue { get; set; }
    	[DataMember]
        public decimal TodayUnrealisedFXPnl { get; set; }
    	[DataMember]
        public decimal TodayUnrealisedPricePnl { get; set; }
    	[DataMember]
        public decimal PriceToPositionFXRate { get; set; }
    	[DataMember]
        public Nullable<int> PriceToPositionFXRateId { get; set; }
    	[DataMember]
        public bool PriceIsLastTradePrice { get; set; }
    	[DataMember]
        public Nullable<int> PreviousPortfolioId { get; set; }
    	[DataMember]
        public Nullable<decimal> BondNominal { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCarryAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> Delta { get; set; }
    	[DataMember]
        public Nullable<decimal> UnderlyingPrice { get; set; }
    	[DataMember]
        public Nullable<int> DeltaId { get; set; }
    	[DataMember]
        public Nullable<int> UnderlyingPriceId { get; set; }
    	[DataMember]
        public Nullable<decimal> UnderlyingPriceToPositionFXRate { get; set; }
    	[DataMember]
        public Nullable<int> UnderlyingPriceToPositionFXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationFXRate { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationPriceToPositionFXRate { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationMarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> HedgeRatio { get; set; }
    	[DataMember]
        public Nullable<int> HedgeRatioId { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaShortTerm { get; set; }
    	[DataMember]
        public Nullable<int> BetaShortTermId { get; set; }
    	[DataMember]
        public Nullable<decimal> BetaLongTerm { get; set; }
    	[DataMember]
        public Nullable<int> BetaLongTermId { get; set; }
    	[DataMember]
        public System.DateTime PreviousReferenceDate { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCapitalChange { get; set; }
    	[DataMember]
        public Nullable<decimal> IndexRatio { get; set; }
    	[DataMember]
        public Nullable<int> IndexRatioID { get; set; }
    	[DataMember]
        public decimal DisclosedNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationDeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayDeltaNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayDeltaNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowDeltaNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowDeltaNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowRealisedFxPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowRealisedPricePnl { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationDeltaMarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayRealisedFxPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayRealisedPricePnl { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayUnrealisedFxPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayUnrealisedPricePnl { get; set; }
    	[DataMember]
        public decimal ITDRealisedPricePnl { get; set; }
    	[DataMember]
        public decimal ITDRealisedFXPnl { get; set; }
    	[DataMember]
        public decimal OriginalDeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public decimal OriginalDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public bool IsNetPositionLong { get; set; }
    	[DataMember]
        public bool IsExposureLong { get; set; }
    	[DataMember]
        public bool IsFlat { get; set; }
    	[DataMember]
        public bool ValuesExistToRollForward { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAmortisation { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalAmortisation { get; set; }
    	[DataMember]
        public Nullable<decimal> Yield { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> AmortisationCost { get; set; }
    	[DataMember]
        public Nullable<decimal> AmortisationQuantity { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAmortisationBook { get; set; }
    	[DataMember]
        public Nullable<decimal> InflationAssumption { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayRealisedAmortisation { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowDeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorMarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorFXRate { get; set; }
    	[DataMember]
        public decimal MarketValueInstrument { get; set; }
    	[DataMember]
        public decimal DeltaMarketValueInstrument { get; set; }
    	[DataMember]
        public decimal TodayUnrealisedPricePNLInstrument { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationMarketValueInstrument { get; set; }
    	[DataMember]
        public Nullable<decimal> OpeningTotalAmortisation { get; set; }
    	[DataMember]
        public Nullable<bool> ReValue { get; set; }
    	[DataMember]
        public Nullable<int> MarketDataStatus { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayMaxDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTodayMaxDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationTomorrowMaxDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayMaxNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> ForwardFXRate { get; set; }
    	[DataMember]
        public Nullable<int> ForwardFXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationOriginalDeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ParentFundPrice { get; set; }
    	[DataMember]
        public Nullable<int> ParentFundPriceId { get; set; }
    	[DataMember]
        public Nullable<decimal> ParentIndicativeChange { get; set; }
    	[DataMember]
        public Nullable<int> ParentExternalIndicativeChangeId { get; set; }
    	[DataMember]
        public Nullable<int> ParentInternalIndicativeChangeId { get; set; }
    	[DataMember]
        public Nullable<int> ParentFundFXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> ParentFundFXRate { get; set; }
    	[DataMember]
        public Nullable<decimal> IndicativePrice { get; set; }
    	[DataMember]
        public Nullable<decimal> IndicativeFXRate { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationOriginalDeltaNetCostInstrumentCurrency { get; set; }
    
        [DataMember]
        public virtual Position Position { get; set; }
        [DataMember]
        public virtual Portfolio PreviousPortfolio { get; set; }
        [DataMember]
        public virtual List<Exposure> Exposures { get; set; }
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual List<AttributionPnl> AttributionPnls { get; set; }
    }
}
