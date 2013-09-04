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
    public partial class ClientTrade
    {
    	[DataMember]
        public int ClientTradeId { get; set; }
    	[DataMember]
        public System.DateTime SettlementDate { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public string TradeReference { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
    	[DataMember]
        public decimal Discount { get; set; }
    	[DataMember]
        public decimal NetConsideration { get; set; }
    	[DataMember]
        public decimal Commission { get; set; }
    	[DataMember]
        public decimal DilutionLevy { get; set; }
    	[DataMember]
        public int ClientAccountId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int ClientTradeTypeId { get; set; }
    	[DataMember]
        public decimal HWMPrice { get; set; }
    	[DataMember]
        public decimal CurrentQuantity { get; set; }
    	[DataMember]
        public decimal EqFactor { get; set; }
    	[DataMember]
        public decimal Balance { get; set; }
    	[DataMember]
        public decimal TotalCost { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorCurrentQuantity { get; set; }
    	[DataMember]
        public decimal Cost { get; set; }
    	[DataMember]
        public Nullable<int> RelatedTradeId { get; set; }
    	[DataMember]
        public Nullable<decimal> TransferPriceOverride { get; set; }
    
        [DataMember]
        public virtual ClientAccount ClientAccount { get; set; }
    }
}
