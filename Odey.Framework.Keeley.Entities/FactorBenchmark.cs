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
    public partial class FactorBenchmark
    {
    	
        public FactorBenchmark()
        {
            this.FactorExposures = new List<FactorExposure>();
        }
    
    	[DataMember]
        public int FactorBenchmarkId { get; set; }
    	[DataMember]
        public string BenchmarkName { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserId { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual List<FactorExposure> FactorExposures { get; set; }
    }
}
