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
    public partial class CustodianPortfolio
    {
    	[DataMember]
        public int PositionId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int CustodianPortfolioId { get; set; }
    	[DataMember]
        public int CustodianPortfolioTypeId { get; set; }
    	[DataMember]
        public int CustodianPortfolioControlId { get; set; }
    
        [DataMember]
        public virtual Position Position { get; set; }
        [DataMember]
        public virtual CustodianPortfolioControl CustodianPortfolioControl { get; set; }
    }
}
