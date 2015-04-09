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
        public int RequestUserID { get; set; }
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public int PADealingAccountID { get; set; }
    	[DataMember]
        public Nullable<decimal> RequestQuantity { get; set; }
    	[DataMember]
        public Nullable<decimal> RequestValue { get; set; }
    	[DataMember]
        public string RequestNotes { get; set; }
    	[DataMember]
        public System.DateTime RequestTimeStamp { get; set; }
    	[DataMember]
        public bool IsAutomaticRejection { get; set; }
    	[DataMember]
        public Nullable<int> RejectionReasonID { get; set; }
    	[DataMember]
        public Nullable<decimal> ActualQuantity { get; set; }
    	[DataMember]
        public bool IsContractReceived { get; set; }
    	[DataMember]
        public Nullable<bool> IsComplianceApproved { get; set; }
    	[DataMember]
        public Nullable<int> ComplianceUserID { get; set; }
    	[DataMember]
        public string ComplianceNotes { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ComplianceTimeStamp { get; set; }
    	[DataMember]
        public Nullable<bool> IsTraderApproved { get; set; }
    	[DataMember]
        public Nullable<int> TraderUserID { get; set; }
    	[DataMember]
        public string TraderNotes { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TraderTimeStamp { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public bool IsExistingHolding { get; set; }
    	[DataMember]
        public bool IsPending { get; set; }
    	[DataMember]
        public byte[] ContractNoteFile { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ContractNoteTimeStamp { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public string ContractNoteFileName { get; set; }
    	[DataMember]
        public Nullable<decimal> ActualValue { get; set; }
    
        [DataMember]
        public virtual ApplicationUser ComplianceUser { get; set; }
        [DataMember]
        public virtual ApplicationUser RequestUser { get; set; }
        [DataMember]
        public virtual ApplicationUser TraderUser { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual PADealingAccount PADealingAccount { get; set; }
    }
}
