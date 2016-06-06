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
    public partial class LegalEntity
    {
    	[DataMember]
        public int LegalEntityID { get; set; }
    	[DataMember]
        public Nullable<int> FMOrgId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string LongName { get; set; }
    	[DataMember]
        public int CountryID { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> BBCompany { get; set; }
    	[DataMember]
        public Nullable<int> CountryOfIncorporationId { get; set; }
    	[DataMember]
        public int CountryOfDomicileId { get; set; }
    	[DataMember]
        public Nullable<int> ParentLegalEntityId { get; set; }
    	[DataMember]
        public string PulseIdentifier { get; set; }
    }
}
