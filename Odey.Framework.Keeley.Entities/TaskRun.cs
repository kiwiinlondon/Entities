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
    public partial class TaskRun
    {
    	
        public TaskRun()
        {
            this.TaskResults = new List<TaskResult>();
            this.TaskStates = new List<TaskState>();
        }
    
    	[DataMember]
        public int TaskRunId { get; set; }
    	[DataMember]
        public int InitiatingTaskId { get; set; }
    	[DataMember]
        public System.DateTime InitiatingTime { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> CompletionTime { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int TaskRunStateId { get; set; }
    
        [DataMember]
        public virtual Task InitiatingTask { get; set; }
        [DataMember]
        public virtual List<TaskResult> TaskResults { get; set; }
        [DataMember]
        public virtual List<TaskState> TaskStates { get; set; }
    }
}
