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
    public partial class AttributionNav
    {
    	[DataMember]
        public int AttributionNavId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int AttributionSourceId { get; set; }
    	[DataMember]
        public decimal OpeningNAV { get; set; }
    	[DataMember]
        public decimal NAV { get; set; }
    	[DataMember]
        public decimal CapitalChange { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public decimal PercentageOfFund { get; set; }
    	[DataMember]
        public Nullable<bool> RebuildMasterAttribution { get; set; }
    	[DataMember]
        public bool KeeleyIsMaster { get; set; }
    }
}
