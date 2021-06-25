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
    public partial class RepoTradeEvent
    {
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public int CollatoralInstrumentMarketID { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public System.DateTime SettlementDate { get; set; }
    	[DataMember]
        public System.DateTime TerminationTradeDate { get; set; }
    	[DataMember]
        public System.DateTime TerminationSettlementDate { get; set; }
    	[DataMember]
        public int TraderId { get; set; }
    	[DataMember]
        public decimal DirtyPrice { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public bool IsReverse { get; set; }
    	[DataMember]
        public int SettlementCurrencyId { get; set; }
    	[DataMember]
        public decimal Consideration { get; set; }
    	[DataMember]
        public decimal TerminationConsideration { get; set; }
    	[DataMember]
        public int CounterpartyId { get; set; }
    	[DataMember]
        public decimal SettlementInstrumentFXRate { get; set; }
    	[DataMember]
        public bool SettlementInstrumentFXRateMultiply { get; set; }
    	[DataMember]
        public int DayCountConventionId { get; set; }
    	[DataMember]
        public decimal RepoCoupon { get; set; }
    	[DataMember]
        public int PaymentFrequency { get; set; }
    	[DataMember]
        public string Ticket { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public int AmendmentNumber { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime InputDate { get; set; }
    	[DataMember]
        public bool SupressFromExtracts { get; set; }
    	[DataMember]
        public System.DateTime OriginalInputDate { get; set; }
    	[DataMember]
        public System.DateTime TradeDateAsDate { get; set; }
    
        [DataMember]
        public virtual Counterparty Counterparty { get; set; }
        [DataMember]
        public virtual Event Event { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
