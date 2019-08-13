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
    public partial class EntityType
    {
    	
        public EntityType()
        {
            this.EntityProperties = new List<EntityProperty>();
            this.FactorRelationships = new List<FactorRelationship>();
        }
    
    	[DataMember]
        public int EntityTypeID { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public string FullyQualifiedName { get; set; }
    
        [DataMember]
        public virtual List<EntityProperty> EntityProperties { get; set; }
        [DataMember]
        public virtual List<FactorRelationship> FactorRelationships { get; set; }
    }
}
