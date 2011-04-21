using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    public interface IPortfolio
    {
        int PositionAccountID { get; set; }
        DateTime ReferenceDate { get; set; }
        decimal NetPosition { get; set; }
	    decimal NetCostInstrumentCurrency { get; set; }
	    decimal NetCostBookCurrency { get; set; }
	    decimal DeltaNetCostInstrumentCurrency { get; set; }
	    decimal DeltaNetCostBookCurrency { get; set; }
	    decimal TodayNetPostionChange { get; set; }
	    decimal TodayDeltaNetCostChangeInstrumentCurrency { get; set; }
	    decimal TodayDeltaNetCostChangeBookCurrency { get; set; }
	    decimal TodayNetCostChangeInstrumentCurrency { get; set; }
        decimal TodayNetCostChangeBookCurrency { get; set; }
    }
}
