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
    public partial class Beta
    {
    	
        public Beta()
        {
            this.AttributionPnls = new List<AttributionPnl>();
            this.AttributionPnls1 = new List<AttributionPnl>();
        }
    
    	[DataMember]
        public int BetaId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public int RelativeIndexInstrumentMarketId { get; set; }
    	[DataMember]
        public int CurrencyId { get; set; }
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
        public int AnalyticTypeId { get; set; }
    	[DataMember]
        public System.DateTime UpdateDate { get; set; }
    	[DataMember]
        public bool UpdatedOnReferenceDay { get; set; }
    	[DataMember]
        public bool IsDummy { get; set; }
    
        [DataMember]
        public virtual Currency Currency { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual InstrumentMarket RelativeIndexInstrumentMarket { get; set; }
        [DataMember]
        public virtual List<AttributionPnl> AttributionPnls { get; set; }
        [DataMember]
        public virtual List<AttributionPnl> AttributionPnls1 { get; set; }
    }
}
