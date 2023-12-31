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
    public partial class TradeEvent
    {
    	[DataMember]
        public int EventID { get; set; }
    	[DataMember]
        public int InstrumentMarketID { get; set; }
    	[DataMember]
        public System.DateTime TradeDate { get; set; }
    	[DataMember]
        public System.DateTime SettlementDate { get; set; }
    	[DataMember]
        public int TraderId { get; set; }
    	[DataMember]
        public decimal GrossPrice { get; set; }
    	[DataMember]
        public decimal NetPrice { get; set; }
    	[DataMember]
        public decimal Quantity { get; set; }
    	[DataMember]
        public int BuySellReasonId { get; set; }
    	[DataMember]
        public bool TradedNet { get; set; }
    	[DataMember]
        public bool PriceIsClean { get; set; }
    	[DataMember]
        public int TradeCurrencyId { get; set; }
    	[DataMember]
        public int SettlementCurrencyId { get; set; }
    	[DataMember]
        public decimal NetConsideration { get; set; }
    	[DataMember]
        public decimal GrossConsideration { get; set; }
    	[DataMember]
        public int CounterpartyId { get; set; }
    	[DataMember]
        public decimal TradeSettlementFXRate { get; set; }
    	[DataMember]
        public bool TradeSettlementFXRateMultiply { get; set; }
    	[DataMember]
        public decimal TradeInstrumentFXRate { get; set; }
    	[DataMember]
        public bool TradeInstrumentFXRateMultiply { get; set; }
    	[DataMember]
        public string Ticket { get; set; }
    	[DataMember]
        public bool IsCancelled { get; set; }
    	[DataMember]
        public int AmendmentNumber { get; set; }
    	[DataMember]
        public System.DateTime StartDt { get; set; }
    	[DataMember]
        public int UpdateUserID { get; set; }
    	[DataMember]
        public byte[] DataVersion { get; set; }
    	[DataMember]
        public System.DateTime InputDate { get; set; }
    	[DataMember]
        public bool SupressFromExtracts { get; set; }
    	[DataMember]
        public decimal TradeEuroFXRate { get; set; }
    	[DataMember]
        public Nullable<int> TradeEuroFXRateId { get; set; }
    	[DataMember]
        public bool IsRoll { get; set; }
    	[DataMember]
        public Nullable<int> ContraEventId { get; set; }
    	[DataMember]
        public System.DateTime OriginalInputDate { get; set; }
    	[DataMember]
        public Nullable<decimal> IndexRatio { get; set; }
    	[DataMember]
        public System.DateTime TradeDateAsDate { get; set; }
    	[DataMember]
        public Nullable<decimal> RealisedPnlBookCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> RealisedPnlInstrumentCurrency { get; set; }
    	[DataMember]
        public Nullable<decimal> CostPriceOverride { get; set; }
    	[DataMember]
        public Nullable<decimal> Yield { get; set; }
    	[DataMember]
        public string MarkitParentOrderId { get; set; }
    	[DataMember]
        public Nullable<decimal> ArrivalPrice { get; set; }
    	[DataMember]
        public Nullable<decimal> IntervalVolumePercent { get; set; }
    	[DataMember]
        public Nullable<decimal> IntervalVWAP { get; set; }
    	[DataMember]
        public Nullable<decimal> InflationAssumption { get; set; }
    	[DataMember]
        public string EzeParentTradeId { get; set; }
    	[DataMember]
        public Nullable<bool> AdjustQuantityOnly { get; set; }
    	[DataMember]
        public Nullable<System.DateTime> TradeDateOverride { get; set; }
    	[DataMember]
        public System.DateTime OrderSentToBrokerDate { get; set; }
    	[DataMember]
        public Nullable<decimal> NetAmount { get; set; }
    	[DataMember]
        public Nullable<bool> RebuildTrade { get; set; }
    	[DataMember]
        public string MICCode { get; set; }
    
        [DataMember]
        public virtual Event Event { get; set; }
        [DataMember]
        public virtual InstrumentMarket InstrumentMarket { get; set; }
        [DataMember]
        public virtual Counterparty Counterparty { get; set; }
    }
}
