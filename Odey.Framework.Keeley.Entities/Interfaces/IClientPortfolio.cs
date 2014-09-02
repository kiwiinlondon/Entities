using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities.Interfaces
{
    public interface IClientPortfolio
    {
        decimal OpeningValue { get; set; }
        decimal TodayRedemptionPnl { get; set; }
        decimal OpeningValueAfterTodaysTrades { get; set; }
        decimal TodayPnl { get; set; }
        decimal TodayReturn { get; set; }
        decimal ITDReturn { get; set; } 
    }
}
