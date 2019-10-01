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
        public int AttributionNavId { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
    	[DataMember]
        public decimal TodayOtherPnl { get; set; }
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
        public virtual AttributionNav AttributionNav { get; set; }
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual Portfolio Portfolio { get; set; }
    }
}
