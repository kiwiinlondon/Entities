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
    public partial class Option
    {
    	[DataMember]
        public int InstrumentId { get; set; }
    	[DataMember]
        public bool IsPut { get; set; }
    	[DataMember]
        public decimal StrikePrice { get; set; }
    	[DataMember]
        public System.DateTime ExpiryDate { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<decimal> ContractSize { get; set; }
    	[DataMember]
        public Nullable<int> OptionExerciseTypeId { get; set; }
    
        [DataMember]
        public virtual Instrument Instrument { get; set; }
    }
}
