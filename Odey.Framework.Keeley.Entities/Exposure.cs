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
    public partial class Exposure
    {
    	[DataMember]
        public int ExposureId { get; set; }
    	[DataMember]
        public int PositionId { get; set; }
    	[DataMember]
        public int InstrumentId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public Nullable<decimal> EquityExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> CommodityExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> FixedIncomeExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> OtherExposure { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int PortfolioId { get; set; }
    	[DataMember]
        public Nullable<decimal> CurrencyExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> GovernmentBondExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeEquityExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeCurrencyExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeCommodityExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeFixedIncomeExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeOtherExposure { get; set; }
    	[DataMember]
        public Nullable<decimal> ChangeGovernmentBondExposure { get; set; }
    
        [DataMember]
        public virtual Portfolio Portfolio { get; set; }
    }
}
