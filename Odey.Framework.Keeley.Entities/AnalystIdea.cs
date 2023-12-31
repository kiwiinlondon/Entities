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
    public partial class AnalystIdea
    {
    	[DataMember]
        public int AnalystIdeaId { get; set; }
    	[DataMember]
        public Nullable<int> AnalystId { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ResearchNoteLastReceived { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int IssuerId { get; set; }
    	[DataMember]
        public Nullable<int> ExternalOriginatorId { get; set; }
    	[DataMember]
        public Nullable<int> InternalOriginatorId { get; set; }
    	[DataMember]
        public Nullable<int> InternalOriginatorId2 { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> OriginatingDate { get; set; }
    	[DataMember]
        public Nullable<bool> IsOriginatedLong { get; set; }
    	[DataMember]
        public Nullable<int> ExternalBrokerId { get; set; }
    
        [DataMember]
        public virtual ApplicationUser Analyst { get; set; }
        [DataMember]
        public virtual Issuer Issuer { get; set; }
        [DataMember]
        public virtual ApplicationUser InternalOriginator { get; set; }
        [DataMember]
        public virtual ApplicationUser InternalOriginator2 { get; set; }
        [DataMember]
        public virtual ExternalPerson ExternalOriginator { get; set; }
        [DataMember]
        public virtual ResearchBroker ResearchBroker { get; set; }
    }
}
