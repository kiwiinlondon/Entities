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
    
    public partial class Research_Search_Result
    {
        public int ResearchId { get; set; }
        public string Subject { get; set; }
        public Nullable<System.Guid> CodeRedId { get; set; }
        public System.DateTime CreatedDt { get; set; }
        public string Analyst { get; set; }
        public string BloombergTicker { get; set; }
        public string Country { get; set; }
        public string Attachment { get; set; }
        public string Issuer { get; set; }
        public string Sector { get; set; }
        public string AdditionalKeywords { get; set; }
    }
}
