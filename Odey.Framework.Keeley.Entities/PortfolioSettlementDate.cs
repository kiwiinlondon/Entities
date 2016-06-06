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
    using TypeLite;
    [TsClass]
    [DataContract(IsReference = true)]
    public partial class PortfolioSettlementDate
    {
    	[DataMember]
        public int PortfolioSettlementDateId { get; set; }
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
    }
}
