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
    public partial class InstrumentEvent
    {
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public int InstrumentEventTypeID { get; set; }
    	[DataMember]
        public System.DateTime EventDate { get; set; }
    	[DataMember]
        public System.DateTime ValueDate { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int AmendmentNumber { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public System.DateTime InputDate { get; set; }
    	[DataMember]
        public System.DateTime ExDate { get; set; }
    	[DataMember]
        public Nullable<decimal> Price { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> EventDateOverride { get; set; }
    	[DataMember]
        public bool IsPNLOnly { get; set; }
    	[DataMember]
        public Nullable<int> CorporateActionId { get; set; }
    	[DataMember]
        public Nullable<decimal> NetPosition { get; set; }
    
        [DataMember]
        public virtual Event Event { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
