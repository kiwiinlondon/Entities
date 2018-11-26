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
    public partial class EzeTrade
    {
    	[DataMember]
        public string ParentTradeID { get; set; }
    	[DataMember]
        public string TradeID { get; set; }
    	[DataMember]
        public string LotID { get; set; }
    	[DataMember]
        public string FMID { get; set; }
    	[DataMember]
        public string BrokerCode { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> OrderTimestamp { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TradeTimestamp { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public decimal ResearchCommission { get; set; }
    	[DataMember]
        public Nullable<double> ExecutionCommission { get; set; }
    	[DataMember]
        public Nullable<double> CFD_GrossPrice { get; set; }
    	[DataMember]
        public Nullable<double> CFD_GrossMoney { get; set; }
    	[DataMember]
        public Nullable<double> CFD_ResearchCommission { get; set; }
    	[DataMember]
        public int CFDFlag { get; set; }
    	[DataMember]
        public int CashFlag { get; set; }
    	[DataMember]
        public int ImpliedCommsFlag { get; set; }
    	[DataMember]
        public string TradeEntrySource { get; set; }
    	[DataMember]
        public int EzeTradeId { get; set; }
    	[DataMember]
        public string BrokerSettlementCurrency { get; set; }
    }
}
