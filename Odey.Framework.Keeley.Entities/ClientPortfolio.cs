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
    public partial class ClientPortfolio
    {
    	[DataMember]
        public int ClientPortfolioId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public decimal ChangeInQuantity { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public int PriceId { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public decimal Cost { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    }
}
