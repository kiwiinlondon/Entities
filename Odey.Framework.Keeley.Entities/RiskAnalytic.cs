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
    public partial class RiskAnalytic
    {
    	[DataMember]
        public int RiskAnalyticId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public int RiskAnalyticTypeId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public Nullable<int> CurrencyId { get; set; }
    	[DataMember]
        public Nullable<decimal> Value1Day { get; set; }
    	[DataMember]
        public Nullable<decimal> Value20Day { get; set; }
    	[DataMember]
        public Nullable<decimal> Value1DayMixedModel { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual Currency Currency { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual RiskAnalyticType RiskAnalyticType { get; set; }
    }
}