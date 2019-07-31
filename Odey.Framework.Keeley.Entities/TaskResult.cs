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
    public partial class TaskResult
    {
    	[DataMember]
        public int TaskResultId { get; set; }
    	[DataMember]
        public int TaskId { get; set; }
    	[DataMember]
        public int TaskResultTypeId { get; set; }
    	[DataMember]
        public string Notes { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int TaskRunId { get; set; }
    	[DataMember]
        public Nullable<int> AffectedEntityCount { get; set; }
    
        [DataMember]
        public virtual Task Task { get; set; }
        [DataMember]
        public virtual TaskRun TaskRun { get; set; }
    }
}
