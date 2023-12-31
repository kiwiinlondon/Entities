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
    public partial class PortfolioEventFX
    {
    	[DataMember]
        public int PortfolioEventFXId { get; set; }
    	[DataMember]
        public int PortfolioEventId { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
    	[DataMember]
        public decimal FromBookFXRate { get; set; }
    	[DataMember]
        public decimal NotionalCost { get; set; }
    	[DataMember]
        public decimal RealisedFXPNL { get; set; }
    	[DataMember]
        public decimal TodayRealisedFXPNL { get; set; }
    	[DataMember]
        public decimal TodayRealisedPricePNL { get; set; }
    	[DataMember]
        public decimal TodayCashBenefit { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public Nullable<int> FXRateId { get; set; }
    	[DataMember]
        public Nullable<decimal> OriginalNotionalCost { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCapitalChange { get; set; }
    	[DataMember]
        public Nullable<decimal> CapitalChange { get; set; }
    
        [DataMember]
        public virtual PortfolioEvent PortfolioEvent { get; set; }
    }
}
