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
    public partial class MessageQueue
    {
    	[DataMember]
        public int MessageId { get; set; }
    	[DataMember]
        public int MessageTypeId { get; set; }
    	[DataMember]
        public string Message { get; set; }
    	[DataMember]
        public string ChangeType { get; set; }
    	[DataMember]
        public string MessageSource { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public Nullable<int> FundId { get; set; }
    	[DataMember]
        public Nullable<int> AttributionSourceId { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> ReferenceDate { get; set; }
    	[DataMember]
        public Nullable<int> CurrencyId { get; set; }
    	[DataMember]
        public Nullable<int> PositionId { get; set; }
    	[DataMember]
        public Nullable<int> PnlTypeId { get; set; }
    	[DataMember]
        public Nullable<int> CounterpartyId { get; set; }
    	[DataMember]
        public Nullable<int> AttributionPnlId { get; set; }
    }
}
