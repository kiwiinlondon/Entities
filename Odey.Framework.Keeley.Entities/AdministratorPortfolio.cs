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
    public partial class AdministratorPortfolio
    {
    	[DataMember]
        public int AdministratorPortfolioID { get; set; }
    	[DataMember]
        public Nullable<int> FundId { get; set; }
    	[DataMember]
        public Nullable<int> InstrumentMarketId { get; set; }
    	[DataMember]
        public string InstrumentName { get; set; }
    	[DataMember]
        public bool IsAccrual { get; set; }
    	[DataMember]
        public decimal NetPosition { get; set; }
    	[DataMember]
        public decimal MarketValue { get; set; }
    	[DataMember]
        public decimal Price { get; set; }
    	[DataMember]
        public decimal FXRate { get; set; }
    	[DataMember]
        public decimal RealisedPricePNL { get; set; }
    	[DataMember]
        public decimal RealisedFXPNL { get; set; }
    	[DataMember]
        public decimal UnRealisedPricePNL { get; set; }
    	[DataMember]
        public decimal UnRealisedFXPNL { get; set; }
    	[DataMember]
        public decimal CarryPNL { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
