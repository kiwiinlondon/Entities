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
    public partial class Bond
    {
    	[DataMember]
        public int InstrumentId { get; set; }
    	[DataMember]
        public int DayCountConventionID { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> FirstCouponDate { get; set; }
    	[DataMember]
        public int CouponFrequency { get; set; }
    	[DataMember]
        public decimal Coupon { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public bool InDefault { get; set; }
    	[DataMember]
        public System.DateTime MaturityDate { get; set; }
    	[DataMember]
        public decimal ParAmount { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> IssueDate { get; set; }
    	[DataMember]
        public Nullable<decimal> IssuePrice { get; set; }
    	[DataMember]
        public Nullable<bool> IsFixed { get; set; }
    	[DataMember]
        public Nullable<int> BondMaturityTypeId { get; set; }
    	[DataMember]
        public Nullable<decimal> ConversionPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> MaturityValue { get; set; }
    	[DataMember]
        public Nullable<bool> IsCovered { get; set; }
    
        [DataMember]
        public virtual Instrument Instrument { get; set; }
    }
}
