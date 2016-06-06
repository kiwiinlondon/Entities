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
    using TypeLite;
    [TsClass]
    [DataContract(IsReference = true)]
    public partial class Price
    {
    	
        public Price()
        {
            this.InterestRateReturns = new List<InterestRateReturn>();
        }
    
    	[DataMember]
        public int PriceId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public int EntityRankingSchemeId { get; set; }
    	[DataMember]
        public int RawPriceId { get; set; }
    	[DataMember]
        public decimal Value { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual RawPrice RawPrice { get; set; }
        [DataMember]
        public virtual List<InterestRateReturn> InterestRateReturns { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
