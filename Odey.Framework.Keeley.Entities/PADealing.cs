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
    public partial class PADealing
    {
    	[DataMember]
        public int PADealingID { get; set; }
    	[DataMember]
        public int RequestingUserID { get; set; }
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public bool IsBuy { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public System.DateTime RequestTimeStamp { get; set; }
    	[DataMember]
        public string RequestNote { get; set; }
    	[DataMember]
        public Nullable<bool> IsAutomaticRejection { get; set; }
    	[DataMember]
        public Nullable<bool> IsComplianceApproved { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ComplianceTimeStamp { get; set; }
    	[DataMember]
        public Nullable<int> ComplianceRejectionReasonID { get; set; }
    	[DataMember]
        public string ComplianceNote { get; set; }
    	[DataMember]
        public Nullable<bool> IsTraderApproved { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TraderTimeStamp { get; set; }
    	[DataMember]
        public Nullable<int> TraderRejectionReasonID { get; set; }
    	[DataMember]
        public string TraderNote { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> ComplianceUserId { get; set; }
    	[DataMember]
        public Nullable<int> TraderUserId { get; set; }
    
        [DataMember]
        public virtual ApplicationUser ComplianceUser { get; set; }
        [DataMember]
        public virtual ApplicationUser RequestingUser { get; set; }
        [DataMember]
        public virtual ApplicationUser TraderUser { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}