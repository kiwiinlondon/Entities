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
    public partial class RestrictedList
    {
    	[DataMember]
        public int RestrictedListId { get; set; }
    	[DataMember]
        public int InstrumentId { get; set; }
    	[DataMember]
        public System.DateTime EffvFromDt { get; set; }
    	[DataMember]
        public System.DateTime EffvToDt { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public string OpeningComment { get; set; }
    	[DataMember]
        public string ClosingComment { get; set; }
    	[DataMember]
        public string RestrictedPerson { get; set; }
    	[DataMember]
        public bool WatchListOnly { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    
        [DataMember]
        public virtual Instrument Instrument { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
