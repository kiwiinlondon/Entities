using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odey.Framework.Keeley.Entities
{
    public partial class RepoTradeEvent
    {
        public DateTime? RateEffectiveFromDate
        {
            get
            {
                if (RepoTradeEventRateChanges.Count==0)
                {
                    return null;
                }
                return RepoTradeEventRateChanges.Max(a => a.EffectiveToDate);
            }
        }
    }
}
