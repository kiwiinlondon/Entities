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
    public partial class IssuerIndustry
    {
    	[DataMember]
        public int IssuerIndustryID { get; set; }
    	[DataMember]
        public int IssuerID { get; set; }
    	[DataMember]
        public int IndustryID { get; set; }
    	[DataMember]
        public int IndustryClassificationID { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual Industry Industry { get; set; }
        [DataMember]
        public virtual Issuer Issuer { get; set; }
    }
}
