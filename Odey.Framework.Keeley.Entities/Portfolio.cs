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
        public decimal ValuationFXRate { get; set; }
    	[DataMember]
        public decimal ValuationNetPosition { get; set; }
    	[DataMember]
        public decimal ValuationDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal ValuationPrice { get; set; }
    	[DataMember]
        public decimal ValuationPriceToPositionFXRate { get; set; }
    	[DataMember]
        public decimal ValuationMarketValue { get; set; }
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
        public virtual Position Position { get; set; }
        [DataMember]
        public virtual Portfolio PreviousPortfolio { get; set; }
        [DataMember]
        public virtual List<Exposure> Exposures { get; set; }
    }
}
