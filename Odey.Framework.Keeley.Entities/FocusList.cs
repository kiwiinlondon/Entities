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
    public partial class FocusList
    {
    	[DataMember]
        public int FocusListId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public int AnalystId { get; set; }
    	[DataMember]
        public System.DateTime InDate { get; set; }
    	[DataMember]
        public decimal InPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> StartOfYearPrice { get; set; }
    	[DataMember]
        public bool IsLong { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> OutDate { get; set; }
    	[DataMember]
        public Nullable<decimal> OutPrice { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public decimal CurrentPrice { get; set; }
    	[DataMember]
        public int CurrentPriceId { get; set; }
    	[DataMember]
        public System.DateTime CurrentPriceDate { get; set; }
    	[DataMember]
        public decimal EndOfYearPrice { get; set; }
    	[DataMember]
        public Nullable<int> RelativeIndexInstrumentMarketId { get; set; }
    	[DataMember]
        public Nullable<decimal> RelativeInPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> RelativeOutPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> RelativeEndOfYearPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> RelativeCurrentPrice { get; set; }
    	[DataMember]
        public Nullable<int> RelativeCurrentPriceId { get; set; }
    }
}
