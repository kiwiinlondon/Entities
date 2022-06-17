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
    public partial class OfficialNetAssetValue
    {
    	[DataMember]
        public int OfficialNetAssetValueId { get; set; }
    	[DataMember]
        public int FundId { get; set; }
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
        public Nullable<decimal> InSpecieTransfer { get; set; }
    	[DataMember]
        public Nullable<decimal> UnitsInIssue { get; set; }
    	[DataMember]
        public Nullable<decimal> GrossAssetValue { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayManagementFee { get; set; }
    	[DataMember]
        public bool ValueIsForReferenceDate { get; set; }
    	[DataMember]
        public Nullable<decimal> OpeningGAV { get; set; }
    	[DataMember]
        public Nullable<decimal> PercentageOfFund { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialManagementFee { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialPerformanceFee { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalOfficialPerformanceFee { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialShareClassHedgingPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> NetAssetValueFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> GrossAssetValueFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialManagementFeeFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialPerformanceFeeFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalOfficialPerformanceFeeFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialPNLFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOfficialShareClassHedgingPNLFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> Subscriptions { get; set; }
    	[DataMember]
        public Nullable<decimal> Redemptions { get; set; }
    	[DataMember]
        public Nullable<decimal> SubscriptionsFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> RedemptionsFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> OpeningGAVFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> OpeningNAVFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> OpeningNAV { get; set; }
    	[DataMember]
        public Nullable<decimal> BifurcatedCurrencyGainLoss { get; set; }
    	[DataMember]
        public Nullable<decimal> FXRateToBase { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalOfficialManagementFee { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalOfficialManagementFeeFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> ShareClassSpecificPNL { get; set; }
    	[DataMember]
        public Nullable<bool> ToBeLoaded { get; set; }
    	[DataMember]
        public Nullable<decimal> ShareClassSpecificPNLFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> UncrystallisedPerformanceFeeChange { get; set; }
    	[DataMember]
        public Nullable<decimal> UncrystallisedPerformanceFeeChangeFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> GrossPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> GrossPNLFundCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> MasterNav { get; set; }
    	[DataMember]
        public Nullable<decimal> FeederNav { get; set; }
    	[DataMember]
        public Nullable<bool> CalculateAttributionPNL { get; set; }
    	[DataMember]
        public System.DateTime PreviousValuationDate { get; set; }
    	[DataMember]
        public bool AdministratorPortfolioExists { get; set; }
    	[DataMember]
        public Nullable<bool> RecalculateUnits { get; set; }
    	[DataMember]
        public Nullable<int> IndicativeChangeId { get; set; }
    	[DataMember]
        public Nullable<decimal> IndicativeChange { get; set; }
    	[DataMember]
        public Nullable<decimal> IndicativeGAV { get; set; }
    	[DataMember]
        public Nullable<decimal> ShareClassHWM { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> LastClientFileDate { get; set; }
    	[DataMember]
        public Nullable<decimal> LastClientFileHWM { get; set; }
    	[DataMember]
        public Nullable<decimal> YTDSumUnits { get; set; }
    	[DataMember]
        public Nullable<int> YTDCountValuations { get; set; }
    
        [DataMember]
        public virtual Fund Fund { get; set; }
        [DataMember]
        public virtual Analytic Analytic { get; set; }
    }
}
