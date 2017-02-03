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
    public partial class FactorRelationship
    {
    	
        public FactorRelationship()
        {
            this.FactorRelationship1 = new List<FactorRelationship>();
            this.FactorExposures = new List<FactorExposure>();
        }
    
    	[DataMember]
        public int FactorRelationshipId { get; set; }
    	[DataMember]
        public int FactorHierarchyId { get; set; }
    	[DataMember]
        public string FactorName { get; set; }
    	[DataMember]
        public string BloombergFactorName { get; set; }
    	[DataMember]
        public Nullable<int> ParentFactorRelationshipId { get; set; }
    	[DataMember]
        public Nullable<int> EntityTypeId { get; set; }
    	[DataMember]
        public Nullable<int> EntityId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserId { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual EntityType EntityType { get; set; }
        [DataMember]
        public virtual FactorHierarchy FactorHierarchy { get; set; }
        [DataMember]
        public virtual List<FactorRelationship> FactorRelationship1 { get; set; }
        [DataMember]
        public virtual FactorRelationship FactorRelationship2 { get; set; }
        [DataMember]
        public virtual List<FactorExposure> FactorExposures { get; set; }
    }
}
