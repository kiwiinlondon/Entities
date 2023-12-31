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
    public partial class RawFinancing
    {
    	[DataMember]
        public int RawFinancingId { get; set; }
    	[DataMember]
        public int FinancingId { get; set; }
    	[DataMember]
        public int RawFinancingTypeId { get; set; }
    	[DataMember]
        public Nullable<decimal> Notional { get; set; }
    	[DataMember]
        public Nullable<decimal> Rate { get; set; }
    	[DataMember]
        public Nullable<decimal> Accrual { get; set; }
    	[DataMember]
        public Nullable<decimal> Units { get; set; }
    	[DataMember]
        public Nullable<decimal> Price { get; set; }
    	[DataMember]
        public int DayCount { get; set; }
    	[DataMember]
        public int DayBasis { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int FinancingControlId { get; set; }
    
        [DataMember]
        public virtual Financing Financing { get; set; }
        [DataMember]
        public virtual FinancingControl FinancingControl { get; set; }
    }
}
