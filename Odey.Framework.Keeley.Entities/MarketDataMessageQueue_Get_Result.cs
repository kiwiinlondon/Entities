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
    
    public partial class MarketDataMessageQueue_Get_Result
    {
        public int MessageId { get; set; }
        public int EndPointId { get; set; }
        public int MarketDataEntityTypeId { get; set; }
        public int MarketDataEntityId { get; set; }
        public string Message { get; set; }
        public System.DateTime StartDt { get; set; }
    }
}
