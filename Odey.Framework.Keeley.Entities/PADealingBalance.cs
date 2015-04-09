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
    public partial class PADealingBalance
    {
    	[DataMember]
        public int PADealingBalanceID { get; set; }
    	[DataMember]
        public int UserID { get; set; }
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public int UserAccountID { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime LastPADealDate { get; set; }
    	[DataMember]
        public decimal CurrentPrice { get; set; }
    	[DataMember]
        public int CurrentPriceId { get; set; }
    	[DataMember]
        public decimal BookCost { get; set; }
    	[DataMember]
        public decimal RealisedPNL { get; set; }
    
        [DataMember]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual PADealingAccount PADealingAccount { get; set; }
        [DataMember]
        public virtual Price Price { get; set; }
    }
}
