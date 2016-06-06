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
    using TypeLite;
    [TsClass]
    [DataContract(IsReference = true)]
    public partial class InstrumentClass
    {
    	
        public InstrumentClass()
        {
            this.ParentInstrumentClassRelationships = new List<InstrumentClassRelationship>();
        }
    
    	[DataMember]
        public int InstrumentClassID { get; set; }
    	[DataMember]
        public string FMInstClass { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual List<InstrumentClassRelationship> ParentInstrumentClassRelationships { get; private set; }
    }
}
