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
    using TypeLite;
    [TsClass]
    [DataContract(IsReference = true)]
    public partial class InternalAllocation
    {
    	
        public InternalAllocation()
        {
            this.PortfolioEvents = new List<PortfolioEvent>();
        }
    
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public string FMContEventInd { get; set; }
    	[DataMember]
        public Nullable<int> FMContEventId { get; set; }
    	[DataMember]
        public Nullable<int> FMOriginalContEventId { get; set; }
    	[DataMember]
        public int MatchedStatusId { get; set; }
    	[DataMember]
        public int AccountID { get; set; }
    	[DataMember]
        public int BookID { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public int ParentEventId { get; set; }
    	[DataMember]
        public decimal EventToBookFXRate { get; set; }
    	[DataMember]
        public int StrategyId { get; set; }
    
        [DataMember]
        public virtual List<PortfolioEvent> PortfolioEvents { get; set; }
        [DataMember]
        public virtual Event Event { get; set; }
        [DataMember]
        public virtual Book Book { get; set; }
    }
}
