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
        public Nullable<decimal> TodayFxPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFXGBPPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFXUSDPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFXEURPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCarryPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayManagementFeePnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayPerformanceFeePnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayUnmatchedInstrumentPnl { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOtherItemsPnl { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int AttributionNavId { get; set; }
    	[DataMember]
        public decimal PercentageOfFund { get; set; }
    
        [DataMember]
        public virtual AttributionNav AttributionNav { get; set; }
        [DataMember]
        public virtual Position Position { get; set; }
    }
}
