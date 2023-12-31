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
    public partial class ManagerPriceTarget
    {
    	[DataMember]
        public int ManagerPriceRangeId { get; set; }
    	[DataMember]
        public int ManagerId { get; set; }
    	[DataMember]
        public int InstrumentMarketId { get; set; }
    	[DataMember]
        public Nullable<decimal> StopLossPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> TargetPrice { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    
        [DataMember]
        public virtual ApplicationUser ManagerUser { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
    }
}
