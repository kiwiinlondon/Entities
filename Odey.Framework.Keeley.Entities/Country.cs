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
    public partial class Country
    {
    	
        public Country()
        {
            this.AccountMappings = new List<AccountMapping>();
        }
    
    	[DataMember]
        public int CountryID { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public string IsoCode { get; set; }
    	[DataMember]
        public int RegionID { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<bool> IsEEA { get; set; }
    	[DataMember]
        public Nullable<bool> IsOECD { get; set; }
    	[DataMember]
        public bool IsDevelopedMarket { get; set; }
    	[DataMember]
        public Nullable<int> CurrencyId { get; set; }
    
        [DataMember]
        public virtual List<AccountMapping> AccountMappings { get; set; }
    }
}
