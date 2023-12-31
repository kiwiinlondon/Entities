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
    public partial class ChargeSchedule
    {
    	
        public ChargeSchedule()
        {
            this.LegalEntityChargeSchedules = new List<LegalEntityChargeSchedule>();
        }
    
    	[DataMember]
        public int ChargeScheduleId { get; set; }
    	[DataMember]
        public int InstrumentClassId { get; set; }
    	[DataMember]
        public string Name { get; set; }
    	[DataMember]
        public int ChargeTypeId { get; set; }
    	[DataMember]
        public Nullable<int> IssuerId { get; set; }
    	[DataMember]
        public Nullable<int> CurrencyId { get; set; }
    	[DataMember]
        public bool ApplyToQuantity { get; set; }
    	[DataMember]
        public Nullable<decimal> PercentageToApply { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual List<LegalEntityChargeSchedule> LegalEntityChargeSchedules { get; set; }
    }
}
