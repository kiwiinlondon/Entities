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
    public partial class InterestRateSwap
    {
    	[DataMember]
        public int InstrumentId { get; set; }
    	[DataMember]
        public System.DateTime StartDate { get; set; }
    	[DataMember]
        public System.DateTime MaturityDate { get; set; }
    	[DataMember]
        public int NPVCurrencyId { get; set; }
    	[DataMember]
        public int PayCurrencyId { get; set; }
    	[DataMember]
        public Nullable<decimal> PaySpread { get; set; }
    	[DataMember]
        public decimal PayNotional { get; set; }
    	[DataMember]
        public bool PayIsFloating { get; set; }
    	[DataMember]
        public int PayRollConventionId { get; set; }
    	[DataMember]
        public int PayDayCountConventionId { get; set; }
    	[DataMember]
        public int PayCouponFrequency { get; set; }
    	[DataMember]
        public Nullable<decimal> PayFixedRate { get; set; }
    	[DataMember]
        public Nullable<int> PayFloatingIndexInstrumentMarketId { get; set; }
    	[DataMember]
        public int ReceiveCurrencyId { get; set; }
    	[DataMember]
        public Nullable<decimal> ReceiveSpread { get; set; }
    	[DataMember]
        public decimal ReceiveNotional { get; set; }
    	[DataMember]
        public bool ReceiveIsFloating { get; set; }
    	[DataMember]
        public int ReceiveRollConventionId { get; set; }
    	[DataMember]
        public int ReceiveDayCountConventionId { get; set; }
    	[DataMember]
        public int ReceiveCouponFrequency { get; set; }
    	[DataMember]
        public Nullable<decimal> ReceiveFixedRate { get; set; }
    	[DataMember]
        public Nullable<int> ReceiveFloatingIndexInstrumentMarketId { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime PayFirstPaymentDate { get; set; }
    	[DataMember]
        public System.DateTime ReceiveFirstPaymentDate { get; set; }
    
        [DataMember]
        public virtual Instrument Instrument { get; set; }
    }
}