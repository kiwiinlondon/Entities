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
    public partial class IssuerAnalytic
    {
    	[DataMember]
        public int IssuerAnalyticId { get; set; }
    	[DataMember]
        public int AnalyticTypeID { get; set; }
    	[DataMember]
        public int IssuerId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public decimal Value { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> RawIssuerAnalyticId { get; set; }
    
        [DataMember]
        public virtual RawIssuerAnalytic RawIssuerAnalytic { get; set; }
    }
}
