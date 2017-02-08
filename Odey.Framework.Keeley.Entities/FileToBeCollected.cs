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
    public partial class FileToBeCollected
    {
    	[DataMember]
        public int FileToBeCollectedId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public int FileCollectionTypeId { get; set; }
    	[DataMember]
        public string FileCollectionTypeProfileName { get; set; }
    	[DataMember]
        public string FileDestinationPath { get; set; }
    	[DataMember]
        public string FileNameTemplate { get; set; }
    	[DataMember]
        public Nullable<int> FileNameResolutionTypeId { get; set; }
    	[DataMember]
        public int FileTypeId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public string EmailWhenReceived { get; set; }
    	[DataMember]
        public Nullable<int> FileToBeCollectedGroupId { get; set; }
    	[DataMember]
        public Nullable<int> FundId { get; set; }
    	[DataMember]
        public Nullable<bool> DeleteFromServer { get; set; }
    }
}
