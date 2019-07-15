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
    public partial class Task
    {
    	
        public Task()
        {
            this.Parameters = new List<TaskParameter>();
            this.Dependencies = new List<TaskDependency>();
            this.SubTasks = new List<TaskSubTask>();
        }
    
    	[DataMember]
        public int TaskId { get; set; }
    	[DataMember]
        public int TaskTypeId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual List<TaskParameter> Parameters { get; set; }
        [DataMember]
        public virtual List<TaskDependency> Dependencies { get; set; }
        [DataMember]
        public virtual List<TaskSubTask> SubTasks { get; set; }
    }
}
