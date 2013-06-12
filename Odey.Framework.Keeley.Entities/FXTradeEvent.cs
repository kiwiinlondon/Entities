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
    public partial class FXTradeEvent
    {
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public int ReceiveCurrencyId { get; set; }
    	[DataMember]
        public int PayCurrencyId { get; set; }
    	[DataMember]
        public decimal ReceiveAmount { get; set; }
    	[DataMember]
        public decimal PayAmount { get; set; }
    	[DataMember]
        public bool IsProp { get; set; }
    	[DataMember]
        public bool EnteredMultiply { get; set; }
    	[DataMember]
        public string Ticket { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public int CounterpartyId { get; set; }
    	[DataMember]
        public int AmendmentNumber { get; set; }
    	[DataMember]
        public System.DateTime MaturityDate { get; set; }
    	[DataMember]
        public int TraderId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public bool IsForward { get; set; }
    	[DataMember]
        public System.DateTime InputDate { get; set; }
    	[DataMember]
        public int SettlementCurrencyId { get; set; }
    	[DataMember]
        public bool SupressFromExtracts { get; set; }
    	[DataMember]
        public Nullable<decimal> NonEuroPairReceiveToEuroFXRate { get; set; }
    	[DataMember]
        public Nullable<int> NonEuroPairReceiveToEuroFXRateId { get; set; }
    	[DataMember]
        public bool IsRoll { get; set; }
    	[DataMember]
        public Nullable<int> ContraEventId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> OriginalInputDate { get; set; }
    
        [DataMember]
        public virtual Event Event { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
