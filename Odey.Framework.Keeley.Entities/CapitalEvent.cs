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
    public partial class CapitalEvent
    {
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public System.DateTime SettlementDate { get; set; }
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
        public System.DateTime AdministratorTradeDate { get; set; }
    
        [DataMember]
        public virtual Event Event { get; set; }
    }
}
