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
    public partial class ExtractEntity
    {
    	
        public ExtractEntity()
        {
            this.ExtractEntityPropertyValues = new List<ExtractEntityPropertyValue>();
        }
    
    	[DataMember]
        public int ExtractEntityID { get; set; }
    	[DataMember]
        public int ExtractId { get; set; }
    	[DataMember]
        public int EntityId { get; set; }
    	[DataMember]
        public Nullable<int> LastSentInExtractRunId { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public bool SendInNextRun { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int EntityTypeId { get; set; }
    
        [DataMember]
        public virtual List<ExtractEntityPropertyValue> ExtractEntityPropertyValues { get; set; }
    }
}
