using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odey.Framework.Keeley.Entities
{
    public partial class InterestRateSwap
    {
        public string ReceiveType
        {
            get
            {
                return ReceiveIsFloating ? "Floating" : "Fixed";
            }
        }

        public string PayType
        {
            get
            {
                return PayIsFloating ? "Floating" : "Fixed";
            }
        }
        public decimal FixedLegRate
        {
            get
            {
                return PayIsFloating ? ReceiveFixedRate.Value : PayFixedRate.Value;
            }
        }
        public int FixedLegDayCountId
        {
            get
            {
                return PayIsFloating ? ReceiveDayCountConventionId : PayDayCountConventionId;
            }
        }
        public decimal FixedLegNotional
        {
            get
            {
                return PayIsFloating ? ReceiveNotional : PayNotional;
            }
        }
        public int FixedLegCurrencyId
        {
            get
            {
                return PayIsFloating ? ReceiveCurrencyId : PayCurrencyId;
            }
        }
        public DateTime FixedLegStartDate
        {
            get
            {
                return StartDate;
            }
        }
        public int FixedLegPaymentFrequency
        {
            get
            {
                return PayIsFloating ? ReceiveCouponFrequency : PayCouponFrequency;
            }
        }
        public DateTime FixedLegCouponDate
        {
            get
            {
                return PayIsFloating ? ReceiveFirstPaymentDate : PayFirstPaymentDate;
            }
        }
        public DateTime FixedLegEndDate
        {
            get
            {
                return MaturityDate;
            }
        }
        public int FloatingLegDayCountId
        {
            get
            {
                return PayIsFloating ? PayDayCountConventionId : ReceiveDayCountConventionId;
            }
        }
        public decimal FloatingLegNotional
        {
            get
            {
                return PayIsFloating ? PayNotional : ReceiveNotional;
            }
        }
        public int FloatingLegCurrencyId
        {
            get
            {
                return PayIsFloating ? PayCurrencyId : ReceiveCurrencyId;
            }
        }
        public DateTime FloatingLegStartDate
        {
            get
            {
                return StartDate;
            }
        }
        public int FloatingLegPaymentFrequency
        {
            get
            {
                return PayIsFloating ? PayCouponFrequency : ReceiveCouponFrequency;
            }
        }
        public DateTime FloatingLegCouponDate
        {
            get
            {
                return PayIsFloating ? PayFirstPaymentDate : ReceiveFirstPaymentDate;
            }
        }
        public DateTime FloatingLegEndDate
        {
            get
            {
                return MaturityDate;
            }
        }
        public int FloatingLegIndexInstrumentMarketId
        {
            get
            {
                return PayIsFloating ? PayFloatingIndexInstrumentMarketId.Value : ReceiveFloatingIndexInstrumentMarketId.Value;
            }
        }
        public decimal Spread
        {
            get
            {
                return PayIsFloating ? PaySpread.Value : ReceiveSpread.Value;
            }
        }

        public int FixedRollConventionId
        {
            get
            {
                return PayIsFloating ? ReceiveRollConventionId : PayRollConventionId;
            }
        }

        public int FloatingRollConventionId
        {
            get
            {
                return PayIsFloating ? PayRollConventionId : ReceiveRollConventionId;
            }
        }

    }
}
