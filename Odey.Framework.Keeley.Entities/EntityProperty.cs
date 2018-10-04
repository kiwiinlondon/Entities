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
    public partial class EntityProperty
    {
    	
        public EntityProperty()
        {
            this.ExtractOutputConfigurations2 = new List<ExtractOutputConfiguration>();
        }
    
    	[DataMember]
        public int EntityPropertyID { get; set; }
    	[DataMember]
        public int EntityTypeId { get; set; }
    	[DataMember]
        public bool NeedsToBeCalculated { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<bool> PropertyOnChildEntity { get; set; }
    	[DataMember]
        public int TypeCode { get; set; }
    	[DataMember]
        public Nullable<int> IdentifierTypeId { get; set; }
    	[DataMember]
        public bool IsPrimaryKey { get; set; }
    	[DataMember]
        public Nullable<int> LookupEntityTypeId { get; set; }
    	[DataMember]
        public string InputEntityPropertyIds { get; set; }
    	[DataMember]
        public bool IsFXRate { get; set; }
    	[DataMember]
        public bool CanHaveFXRateApplied { get; set; }
    
        [DataMember]
        public virtual EntityType EntityType { get; set; }
        [DataMember]
        public virtual EntityType LookUpEntityType { get; set; }
        [DataMember]
        public virtual List<ExtractOutputConfiguration> ExtractOutputConfigurations2 { get; set; }
    }
}
