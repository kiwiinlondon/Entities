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
    public partial class ApplicationUser
    {
    	
        public ApplicationUser()
        {
            this.FactsetPortfolios = new List<FactsetPortfolio>();
        }
    
    	[DataMember]
        public int UserID { get; set; }
    	[DataMember]
        public Nullable<int> FMPersID { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string Email { get; set; }
    	[DataMember]
        public string WindowsLogin { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public string Initials { get; set; }
    	[DataMember]
        public bool IsActive { get; set; }
    
        [DataMember]
        public virtual List<FactsetPortfolio> FactsetPortfolios { get; set; }
    }
}
