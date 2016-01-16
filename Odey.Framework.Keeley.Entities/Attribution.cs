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
    public partial class Attribution
    {
    	[DataMember]
        public int AttributionID { get; set; }
    	[DataMember]
        public int PositionId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public Nullable<int> PortfolioId { get; set; }
    	[DataMember]
        public Nullable<int> AttributionFundId { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayAdministratorFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public decimal TodayPricePNL { get; set; }
    	[DataMember]
        public decimal TodayFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public decimal TodayFXPNL { get; set; }
    	[DataMember]
        public decimal TodayFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public decimal TodayCarryPNL { get; set; }
    	[DataMember]
        public decimal TodayFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyPricePNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyFXPNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyCarryPNL { get; set; }
    	[DataMember]
        public decimal TodayKeeleyFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayFactsetFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayBookAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayBookAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayBookAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDAdministratorFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public decimal ITDPricePNL { get; set; }
    	[DataMember]
        public decimal ITDFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public decimal ITDFXPNL { get; set; }
    	[DataMember]
        public decimal ITDFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public decimal ITDCarryPNL { get; set; }
    	[DataMember]
        public decimal ITDFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyPricePNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyFXPNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyCarryPNL { get; set; }
    	[DataMember]
        public decimal ITDKeeleyFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDFactsetFundAdjustedOtherPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDBookAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDBookAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDBookAdjustedCarryPNL { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public decimal AdjustmentFactor { get; set; }
    	[DataMember]
        public decimal AdministratorAdjustmentFactor { get; set; }
    	[DataMember]
        public decimal KeeleyAdjustmentFactor { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayValuationFundAdjustedCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationFundAdjustedPricePNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationFundAdjustedFXPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationCarryPNL { get; set; }
    	[DataMember]
        public Nullable<decimal> ITDValuationFundAdjustedCarryPNL { get; set; }
    
        [DataMember]
        public virtual Position Position { get; set; }
        [DataMember]
        public virtual AttributionFund AttributionFund { get; set; }
    }
}
