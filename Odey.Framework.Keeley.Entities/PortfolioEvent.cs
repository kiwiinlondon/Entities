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
    public partial class PortfolioEvent
    {
    	
        public PortfolioEvent()
        {
            this.PortfolioEventFXs = new List<PortfolioEventFX>();
        }
    
    	[DataMember]
        public int PortfolioEventID { get; set; }
    	[DataMember]
        public int InternalAllocationId { get; set; }
    	[DataMember]
        public int PositionId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int PortfolioAggregationLevelId { get; set; }
    	[DataMember]
        public int PortfolioEventTypeId { get; set; }
    	[DataMember]
        public int ChangeNumber { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public decimal FXRate { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public decimal NetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal NetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public decimal NetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal NetCostBookCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal DeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetPositionChange { get; set; }
    	[DataMember]
        public decimal TodayDeltaNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal TodayDeltaNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetCostChangeInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal TodayNetCostChangeBookCurrency { get; set; }
    	[DataMember]
        public decimal NetPosition { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime InputDate { get; set; }
    	[DataMember]
        public int OrderingResolution { get; set; }
    	[DataMember]
        public decimal Accrual { get; set; }
    	[DataMember]
        public decimal TodayAccrual { get; set; }
    	[DataMember]
        public decimal CashBenefit { get; set; }
    	[DataMember]
        public decimal TodayCashBenefit { get; set; }
    	[DataMember]
        public decimal TodayCashBenefitBookCurrency { get; set; }
    	[DataMember]
        public decimal RealisedPricePnl { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePnl { get; set; }
    	[DataMember]
        public decimal RealisedFxPnl { get; set; }
    	[DataMember]
        public decimal TodayRealisedFxPnl { get; set; }
    	[DataMember]
        public decimal TotalAccrual { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePnlBookCurrency { get; set; }
    	[DataMember]
        public bool RealisePnl { get; set; }
    	[DataMember]
        public decimal TradeInstrumentFXRate { get; set; }
    	[DataMember]
        public bool ZeroOutAccrual { get; set; }
    	[DataMember]
        public Nullable<decimal> BondNominal { get; set; }
    	[DataMember]
        public Nullable<decimal> BondNominalChange { get; set; }
    	[DataMember]
        public Nullable<decimal> CapitalChange { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCapitalChange { get; set; }
    	[DataMember]
        public Nullable<int> FXRateId { get; set; }
    	[DataMember]
        public bool UseFXRateForDay { get; set; }
    	[DataMember]
        public Nullable<decimal> RealisedCash { get; set; }
    	[DataMember]
        public Nullable<decimal> ExternalRealisedPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> OriginalDeltaNetCostBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> OriginalDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public decimal ITDRealisedPricePnl { get; set; }
    	[DataMember]
        public decimal ITDRealisedFXPnl { get; set; }
    	[DataMember]
        public bool ResetCost { get; set; }
    	[DataMember]
        public Nullable<decimal> Yield { get; set; }
    	[DataMember]
        public Nullable<decimal> BlendedYield { get; set; }
    	[DataMember]
        public Nullable<decimal> AmortisationCost { get; set; }
    	[DataMember]
        public Nullable<decimal> AmortisationQuantity { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalAmortisationQuantity { get; set; }
    	[DataMember]
        public Nullable<decimal> InflationAssumption { get; set; }
    	[DataMember]
        public Nullable<decimal> BlendedInflationAssumption { get; set; }
    	[DataMember]
        public Nullable<int> AssociatedPositionId { get; set; }
    	[DataMember]
        public bool AdjustQuantityOnly { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayMaxDeltaNetCostInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayMaxNetPosition { get; set; }
    	[DataMember]
        public Nullable<decimal> UnadjustedNetPosition { get; set; }
    	[DataMember]
        public Nullable<bool> Revalue { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public Nullable<bool> TodayZeroOutAccrual { get; set; }
    	[DataMember]
        public bool TodayFinancingMustExist { get; set; }
    	[DataMember]
        public bool FinancingMustExist { get; set; }
    
        [DataMember]
        public virtual Position Position { get; set; }
        [DataMember]
        public virtual List<PortfolioEventFX> PortfolioEventFXs { get; set; }
    }
}
