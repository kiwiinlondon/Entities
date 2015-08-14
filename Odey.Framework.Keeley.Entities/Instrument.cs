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
    public partial class Instrument
    {
    	
        public Instrument()
        {
            this.OverlyingRelationships = new List<InstrumentRelationship>();
            this.Exposures = new List<Exposure>();
        }
    
    	[DataMember]
        public int InstrumentID { get; set; }
    	[DataMember]
        public int IssuerID { get; set; }
    	[DataMember]
        public int InstrumentClassID { get; set; }
    	[DataMember]
        public int IssueCurrencyID { get; set; }
    	[DataMember]
        public Nullable<int> FMInstId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string LongName { get; set; }
    	[DataMember]
        public string Isin { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int UnderlyingIssuerId { get; set; }
    	[DataMember]
        public int DerivedAssetClassId { get; set; }
    	[DataMember]
        public string BloombergGlobalId { get; set; }
    	[DataMember]
        public string BloombergTicker { get; set; }
    	[DataMember]
        public Nullable<int> BloombergYellowKeyId { get; set; }
    	[DataMember]
        public bool Is13F { get; set; }
    	[DataMember]
        public string Cusip { get; set; }
    
        [DataMember]
        public virtual InstrumentRelationship UnderlyingRelationship { get; set; }
        [DataMember]
        public virtual List<InstrumentRelationship> OverlyingRelationships { get; set; }
        [DataMember]
        public virtual CollectiveInvestmentScheme CollectiveInvestmentScheme { get; set; }
        [DataMember]
        public virtual ForwardFX ForwardFX { get; set; }
        [DataMember]
        public virtual InstrumentClass InstrumentClass { get; set; }
        [DataMember]
        public virtual Bond Bond { get; set; }
        [DataMember]
        public virtual List<Exposure> Exposures { get; set; }
        [DataMember]
        public virtual Issuer Issuer { get; set; }
    }
}
