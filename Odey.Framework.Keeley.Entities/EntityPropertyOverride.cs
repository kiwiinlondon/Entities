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
    public partial class EntityPropertyOverride
    {
    	[DataMember]
        public int EntityPropertyOverrideId { get; set; }
    	[DataMember]
        public int EntityID { get; set; }
    	[DataMember]
        public int EntityPropertyId { get; set; }
    	[DataMember]
        public Nullable<int> IntValue { get; set; }
    	[DataMember]
        public string StringValue { get; set; }
    	[DataMember]
        public Nullable<decimal> DecimalValue { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> DateTimeValue { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual EntityProperty EntityProperty { get; set; }
    }
}
