using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    public partial class InternalAllocation
    {
        #region Total Charges
        private decimal? _totalOfCharges = null;
        public decimal TotalOfCharges
        {
            get
            {
                if (!_totalOfCharges.HasValue)
                {
                    _totalOfCharges = 0;
                    foreach (Charge charge in Event.Charges)
                    {
                        _totalOfCharges = _totalOfCharges + charge.Quantity;
                    }
                }
                return _totalOfCharges.Value;
            }
        }
        #endregion
    }
}
