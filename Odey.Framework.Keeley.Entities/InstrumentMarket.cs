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
    public partial class InstrumentMarket
    {
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public int InstrumentID { get; set; }
    	[DataMember]
        public int MarketID { get; set; }
    	[DataMember]
        public Nullable<int> FMSecId { get; set; }
    	[DataMember]
        public decimal PriceDivisor { get; set; }
    	[DataMember]
        public string BloombergTicker { get; set; }
    	[DataMember]
        public string Sedol { get; set; }
    	[DataMember]
        public bool IsPrimary { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int PriceCurrencyId { get; set; }
    	[DataMember]
        public int ListingStatusId { get; set; }
    	[DataMember]
        public int UnderlyingInstrumentMarketId { get; set; }
    	[DataMember]
        public int UltimateUnderlyingInstrumentMarketId { get; set; }
    	[DataMember]
        public decimal PriceQuoteMultiplier { get; set; }
    	[DataMember]
        public string BloombergGlobalId { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> LastRepulledFromSourceDate { get; set; }
    	[DataMember]
        public string FactsetId { get; set; }
    	[DataMember]
        public decimal UltimateUnderlyerPerOverlyer { get; set; }
    	[DataMember]
        public Nullable<bool> ResolveFromExternalSource { get; set; }
    	[DataMember]
        public int ExposureCurrencyId { get; set; }
    	[DataMember]
        public string AdministratorId { get; set; }
    	[DataMember]
        public Nullable<bool> IsReverse { get; set; }
    	[DataMember]
        public int RiskCurrencyId { get; set; }
    	[DataMember]
        public int ValuationMethodologyId { get; set; }
    	[DataMember]
        public string CICCode { get; set; }
    	[DataMember]
        public string BloombergCleanTicker { get; set; }
    	[DataMember]
        public string LocalExchangeSymbol { get; set; }
    	[DataMember]
        public string MicCode { get; set; }
    	[DataMember]
        public bool AlwaysUseManualPrice { get; set; }
    	[DataMember]
        public Nullable<bool> IsExposureLong { get; set; }
    	[DataMember]
        public Nullable<int> DividendCurrencyId { get; set; }
    	[DataMember]
        public Nullable<int> AlternativeExposureCurrencyId { get; set; }
    	[DataMember]
        public Nullable<int> NewFMSecId { get; set; }
    
        [DataMember]
        public virtual Instrument Instrument { get; set; }
        [DataMember]
        public virtual InstrumentMarket UnderlyingInstrumentMarket { get; set; }
        [DataMember]
        public virtual Index Index { get; set; }
        [DataMember]
        public virtual InstrumentMarket UltimateUnderlyingInstrumentMarket { get; set; }
        [DataMember]
        public virtual Market Market { get; set; }
        [DataMember]
        public virtual Currency PriceCurrency { get; set; }
        [DataMember]
        public virtual ListingStatus ListingStatus { get; set; }
        [DataMember]
        public virtual Currency DividendCurrency { get; set; }
    }
}
