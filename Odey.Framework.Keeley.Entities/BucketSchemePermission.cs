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
    public partial class BucketSchemePermission
    {
    	[DataMember]
        public int BucketSchemePermissionId { get; set; }
    	[DataMember]
        public int BucketSchemeId { get; set; }
    	[DataMember]
        public Nullable<bool> IsEditable { get; set; }
    	[DataMember]
        public Nullable<int> ApplicationUserId { get; set; }
    	[DataMember]
        public string ADGroupName { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> StartDt { get; set; }
    	[DataMember]
        public Nullable<int> UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual BucketScheme BucketScheme { get; set; }
    }
}
