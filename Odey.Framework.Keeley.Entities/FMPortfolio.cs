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
    public partial class FMPortfolio
    {
    	[DataMember]
        public int FMPortfolioID { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int ISecID { get; set; }
    	[DataMember]
        public int BookId { get; set; }
    	[DataMember]
        public string Currency { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> MaturityDate { get; set; }
    	[DataMember]
        public decimal NetPosition { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public decimal FXRate { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public decimal DeltaMarketValue { get; set; }
    	[DataMember]
        public decimal TotalAccrual { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    }
}
