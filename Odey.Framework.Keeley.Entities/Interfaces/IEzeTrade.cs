using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Interfaces
{
    public interface IEzeTrade
    {
        string ParentTradeID { get; set; }
        string TradeID { get; set; }
        string LotID { get; set; }
        string FMID { get; set; }
        string BrokerCode { get; set; }

        Nullable<System.DateTime> OrderTimestamp { get; set; }

        Nullable<System.DateTime> TradeTimestamp { get; set; }

        decimal Quantity { get; set; }

        decimal ResearchCommission { get; set; }
        Nullable<double> ExecutionCommission { get; set; }

        Nullable<double> CFD_GrossPrice { get; set; }

        Nullable<double> CFD_GrossMoney { get; set; }
        Nullable<double> CFD_ResearchCommission { get; set; }

        int CFDFlag { get; set; }

        int CashFlag { get; set; }

        int ImpliedCommsFlag { get; set; }

        string TradeEntrySource { get; set; }

        string BrokerSettlementCurrency { get; set; }
    }
}
