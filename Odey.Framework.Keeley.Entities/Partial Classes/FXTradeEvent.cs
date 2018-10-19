using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    partial class FXTradeEvent
    {
        #region Trade Currency Id
        public int TradeCurrencyId
        {
            get
            {
                if (SettlementCurrencyId == PayCurrencyId)
                {
                    return PayCurrencyId;
                }
                else
                {
                    return ReceiveCurrencyId;
                }
            }
        }
        #endregion

        #region Contra Currency Id
        public int ContraCurrencyId
        {
            get
            {
                if (TradeCurrencyId == PayCurrencyId)
                {
                    return ReceiveCurrencyId;
                }
                else
                {
                    return PayCurrencyId;
                }
            }
        }
        #endregion

        #region Trade Currency Amount
        public decimal TradeCurrencyAmount
        {
            get
            {
                if (TradeCurrencyId == PayCurrencyId)
                {
                    return PayAmount;
                }
                else
                {
                    return ReceiveAmount;
                }
            }
        }
        #endregion

        #region Contra Currency Amount
        public decimal ContraCurrencyAmount
        {
            get
            {
                if (ContraCurrencyId == PayCurrencyId)
                {
                    return PayAmount;
                }
                else
                {
                    return ReceiveAmount;
                }
            }
        }
        #endregion

        #region Is Buy
        public bool IsBuy
        {
            get
            {
                if (TradeCurrencyId == ReceiveCurrencyId)
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

        #region Rate
        public decimal Rate
        {
            get
            {
                return ContraCurrencyAmount / TradeCurrencyAmount ;
            }
        }

        public decimal PayReceiveRate
        {
            get
            {
                return PayAmount / ReceiveAmount;
            }
        }

        public decimal ReceivePayRate
        {
            get
            {
                return PayAmount / ReceiveAmount;
            }
        }

        #endregion
    }
}
