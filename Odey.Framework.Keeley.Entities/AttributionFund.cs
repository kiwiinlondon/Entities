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
    public partial class AttributionFund
    {
    	
        public AttributionFund()
        {
            this.Attributions = new List<Attribution>();
        }
    
    	[DataMember]
        public int AttributionFundId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public decimal AdjustmentFactor { get; set; }
    	[DataMember]
        public decimal AdjustedNav { get; set; }
    	[DataMember]
        public decimal AdjustedOpeningNav { get; set; }
    	[DataMember]
        public decimal KeeleyAdjustmentFactor { get; set; }
    	[DataMember]
        public decimal KeeleyAdjustedNav { get; set; }
    	[DataMember]
        public decimal KeeleyAdjustedOpeningNav { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorAdjustmentFactor { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorAdjustedNav { get; set; }
    	[DataMember]
        public Nullable<decimal> AdministratorOpeningAdjustedNav { get; set; }
    	[DataMember]
        public bool AdministratorSourced { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> AdministratorPrevious { get; set; }
    	[DataMember]
        public bool FactsetSourced { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> FactsetPrevious { get; set; }
    	[DataMember]
        public decimal KeeleyUnadjustedNav { get; set; }
    	[DataMember]
        public decimal KeeleyTodayCapitalChange { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<decimal> PercentageOfFund { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationAdjustmentFactor { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationAdjustedNav { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationOpeningAdjustedNav { get; set; }
    	[DataMember]
        public Nullable<decimal> ValuationUnadjustedNav { get; set; }
    
        [DataMember]
        public virtual List<Attribution> Attributions { get; set; }
    }
}
