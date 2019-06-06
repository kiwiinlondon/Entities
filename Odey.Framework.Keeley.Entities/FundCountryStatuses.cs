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
    public partial class FundCountryStatuses
    {
    	[DataMember]
        public int FundCountryStatusId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public int CountryId { get; set; }
    	[DataMember]
        public bool HasReportingStatus { get; set; }
    	[DataMember]
        public bool IsRegistered { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> RegistrationRestrictionId { get; set; }
    
        [DataMember]
        public virtual Country Country { get; set; }
        [DataMember]
        public virtual Fund Fund { get; set; }
    }
}
