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
    public partial class HealthCheck
    {
    	[DataMember]
        public int HealthCheckTypeId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public bool ErrorInProgress { get; set; }
    	[DataMember]
        public System.DateTime LastCheckTime { get; set; }
    	[DataMember]
        public int EmailFrequencyMins { get; set; }
    	[DataMember]
        public int HealthCheckId { get; set; }
    	[DataMember]
        public string Arguments { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    }
}
