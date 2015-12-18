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
    public partial class Issuer
    {
    	
        public Issuer()
        {
            this.IssuerIndustries = new List<IssuerIndustry>();
        }
    
    	[DataMember]
        public int LegalEntityID { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public string FactsetId { get; set; }
    	[DataMember]
        public int GicsLevel3IndustryID { get; set; }
    	[DataMember]
        public Nullable<int> IssuerTypeId { get; set; }
    
        [DataMember]
        public virtual LegalEntity LegalEntity { get; set; }
        [DataMember]
        public virtual List<IssuerIndustry> IssuerIndustries { get; set; }
    }
}
