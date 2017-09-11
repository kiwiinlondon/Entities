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
    public partial class Fund
    {
    	[DataMember]
        public int LegalEntityID { get; set; }
    	[DataMember]
        public int CurrencyID { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public bool PositionsExist { get; set; }
    	[DataMember]
        public string PerfFundName { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public int BenchmarkInstrumentMarketId { get; set; }
    	[DataMember]
        public Nullable<int> ParentFundId { get; set; }
    	[DataMember]
        public bool IsActive { get; set; }
    	[DataMember]
        public int FundTypeId { get; set; }
    	[DataMember]
        public bool PriceIsExternallyVisible { get; set; }
    	[DataMember]
        public System.DateTime InceptionDate { get; set; }
    	[DataMember]
        public int RiskFreeInstrumentMarketId { get; set; }
    	[DataMember]
        public int DealingDateDefinitionId { get; set; }
    	[DataMember]
        public string EZEIdentifier { get; set; }
    	[DataMember]
        public bool PortfolioIsExternallyVisible { get; set; }
    	[DataMember]
        public int AssetManagementCompanyId { get; set; }
    	[DataMember]
        public Nullable<int> IntranetOrdering { get; set; }
    	[DataMember]
        public Nullable<int> ReferenceFundId { get; set; }
    	[DataMember]
        public int PerformanceFeeTypeId { get; set; }
    	[DataMember]
        public Nullable<decimal> LossWarning { get; set; }
    	[DataMember]
        public Nullable<decimal> LossTrigger { get; set; }
    	[DataMember]
        public string ShareClassDescriptor { get; set; }
    	[DataMember]
        public Nullable<decimal> PerformanceFee { get; set; }
    	[DataMember]
        public decimal ManagementFee { get; set; }
    	[DataMember]
        public int AdministratorId { get; set; }
    	[DataMember]
        public string AdministratorIdentifier { get; set; }
    	[DataMember]
        public bool IsVoting { get; set; }
    	[DataMember]
        public System.DateTime ClientLoadDate { get; set; }
    	[DataMember]
        public bool IsDistributing { get; set; }
    	[DataMember]
        public int FundStructureId { get; set; }
    	[DataMember]
        public bool HasUKReportingStatus { get; set; }
    	[DataMember]
        public bool IsClosedToNewInvestors { get; set; }
    	[DataMember]
        public bool IsClosedToExistingInvestors { get; set; }
    	[DataMember]
        public bool IsStaffOnly { get; set; }
    	[DataMember]
        public bool IsIsaEligible { get; set; }
    	[DataMember]
        public Nullable<decimal> OtherCostRatio { get; set; }
    	[DataMember]
        public Nullable<decimal> TotalCostRatio { get; set; }
    	[DataMember]
        public bool IsSynthetic { get; set; }
    	[DataMember]
        public int ClientMarketingTypeId { get; set; }
    	[DataMember]
        public Nullable<decimal> PercentageHedged { get; set; }
    	[DataMember]
        public Nullable<bool> IsMainRetailShareClass { get; set; }
    
        [DataMember]
        public virtual DealingDateDefinition DealingDateDefinition { get; set; }
        [DataMember]
        public virtual InstrumentMarket BenchmarkInstrumentMarket { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual LegalEntity LegalEntity { get; set; }
        [DataMember]
        public virtual InstrumentMarket RiskFreeInstrumentMarket { get; set; }
        [DataMember]
        public virtual Currency Currency { get; set; }
    }
}
