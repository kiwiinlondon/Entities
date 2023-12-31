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
    
    public partial class Financing_GetNotApplied_Result
    {
        public int FinancingId { get; set; }
        public int FundId { get; set; }
        public int InstrumentMarketId { get; set; }
        public System.DateTime ReferenceDate { get; set; }
        public int CurrencyId { get; set; }
        public int CustodianId { get; set; }
        public Nullable<decimal> NetPosition { get; set; }
        public Nullable<decimal> Price { get; set; }
        public decimal Notional { get; set; }
        public decimal FinancingRate { get; set; }
        public decimal BorrowRate { get; set; }
        public decimal AllInRate { get; set; }
        public decimal FinancingAccrual { get; set; }
        public decimal BorrowAccrual { get; set; }
        public decimal AllInAccrual { get; set; }
        public System.DateTime StartDt { get; set; }
        public int UpdateUserID { get; set; }
        public byte[] DataVersion { get; set; }
        public Nullable<decimal> OverborrowNotional { get; set; }
        public Nullable<decimal> OverborrowUnits { get; set; }
        public Nullable<decimal> OverborrowRate { get; set; }
        public Nullable<decimal> OverborrowAccrual { get; set; }
        public Nullable<decimal> MarginInterest { get; set; }
        public Nullable<decimal> CashInterest { get; set; }
    }
}
