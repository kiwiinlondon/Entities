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
    public partial class BookNetAssetValue
    {
    	[DataMember]
        public int BookId { get; set; }
    	[DataMember]
        public System.DateTime ReferenceDate { get; set; }
    	[DataMember]
        public Nullable<decimal> MarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> ValautionMarketValue { get; set; }
    	[DataMember]
        public Nullable<decimal> TodayCapitalChange { get; set; }
    	[DataMember]
        public Nullable<long> PositionCount { get; set; }
    }
}
