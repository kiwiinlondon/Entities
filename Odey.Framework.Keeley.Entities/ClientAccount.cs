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
    public partial class ClientAccount
    {
    	
        public ClientAccount()
        {
            this.ClientTrades = new List<ClientTrade>();
            this.ClientPortfolios = new List<ClientPortfolio>();
        }
    
    	[DataMember]
        public int ClientAccountId { get; set; }
    	[DataMember]
        public int ClientId { get; set; }
    	[DataMember]
        public string AccountReference { get; set; }
    	[DataMember]
        public int AdministratorId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public int CountryId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public bool IsActive { get; set; }
    	[DataMember]
        public Nullable<int> ParentClientAccountId { get; set; }
    	[DataMember]
        public Nullable<int> StaffId { get; set; }
    	[DataMember]
        public Nullable<int> FundId { get; set; }
    
        [DataMember]
        public virtual Client Client { get; set; }
        [DataMember]
        public virtual List<ClientTrade> ClientTrades { get; set; }
        [DataMember]
        public virtual List<ClientPortfolio> ClientPortfolios { get; set; }
    }
}
