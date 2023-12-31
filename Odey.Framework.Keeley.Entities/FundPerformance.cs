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
    public partial class FundPerformance
    {
    	[DataMember]
        public int FundPerformanceId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
    	[DataMember]
        public bool IsInception { get; set; }
    	[DataMember]
        public decimal FundPrice { get; set; }
    	[DataMember]
        public int FundPriceId { get; set; }
    	[DataMember]
        public decimal BenchmarkPrice { get; set; }
    	[DataMember]
        public int BenchmarkPriceId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime ValuationBusinessDate { get; set; }
    	[DataMember]
        public System.DateTime ValidUntil { get; set; }
    	[DataMember]
        public decimal BenchmarkFundFXRate { get; set; }
    	[DataMember]
        public Nullable<int> BenchmarkFundFXRateId { get; set; }
    	[DataMember]
        public decimal RiskFreeRate { get; set; }
    	[DataMember]
        public int RiskFreeRatePriceId { get; set; }
    	[DataMember]
        public bool BenchmarkPriceExistsOnDay { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> BenchmarkPriceValidUntil { get; set; }
    	[DataMember]
        public decimal MaxFundPrice { get; set; }
    
        [DataMember]
        public virtual Price BenchmarkPricePrice { get; set; }
    }
}
