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
    public partial class FundClientPlatform
    {
    	[DataMember]
        public int FundClientPlatformId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public int ClientPlatformId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual ClientPlatform ClientPlatform { get; set; }
    }
}
