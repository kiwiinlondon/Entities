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
    public partial class ClientPortfolioBridge
    {
    	[DataMember]
        public int ClientPortfolioBridgeId { get; set; }
    	[DataMember]
        public int ClientAccountId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public int ParentFundId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public bool IsFirst { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public decimal Cost { get; set; }
    
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual ClientAccount ClientAccount { get; set; }
    }
}
