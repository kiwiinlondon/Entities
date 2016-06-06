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
    using TypeLite;
    [TsClass]
    [DataContract(IsReference = true)]
    public partial class FXRate
    {
    	[DataMember]
        public int FXRateId { get; set; }
    	[DataMember]
        public int FromCurrencyId { get; set; }
    	[DataMember]
        public int ToCurrencyId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int EntityRankingSchemeId { get; set; }
    	[DataMember]
        public System.DateTime ForwardDate { get; set; }
    	[DataMember]
        public decimal Value { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> FromRawFXRateId { get; set; }
    	[DataMember]
        public int ToRawFXRateId { get; set; }
    	[DataMember]
        public Nullable<int> FromSecondRawFXRateId { get; set; }
    	[DataMember]
        public Nullable<int> ToSecondRawFXRateId { get; set; }
    
        [DataMember]
        public virtual RawFXRate FromRawFXRate { get; set; }
        [DataMember]
        public virtual RawFXRate ToRawFXRate { get; set; }
        [DataMember]
        public virtual RawFXRate FromSecondRawFXRate { get; set; }
        [DataMember]
        public virtual RawFXRate ToSecondRawFXRate { get; set; }
    }
}
