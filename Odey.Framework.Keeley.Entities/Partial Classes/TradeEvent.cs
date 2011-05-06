using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class TradeEvent
    {
        #region Is Buy
        public bool IsBuy
        {
            get
            {
                if (Quantity >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion

        #region Absolute Quantity
        public decimal AbsoluteQuantity
        {
            get
            {
                return Math.Abs(Quantity);
            }
        }
        #endregion
    }
}
