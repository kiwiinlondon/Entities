using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Enums;

namespace Odey.Framework.Keeley.Entities
{
    public partial class InternalAllocation
    {
        private decimal? _totalOfCharges = null;
        public decimal TotalOfCharges
        {
            get
            {
                if (!_totalOfCharges.HasValue)
                {
                    _totalOfCharges = -Event.Charges.Sum(a => a.Quantity);
                }
                return _totalOfCharges.Value;
            }
        }


        
        private decimal? _commission = null;
        public decimal Commission
        {
            get
            {
                if (!_commission.HasValue)
                {
                    return -Event.Charges.Where(a => a.ChargeTypeId == (int)ChargeTypeIds.Commission).Sum(a => a.Quantity);
                }
                return _commission.Value;
            }
        }
        private decimal? _research = null;
        public decimal Research
        {
            get
            {
                if (!_research.HasValue)
                {
                    return -Event.Charges.Where(a => a.ChargeTypeId == (int)ChargeTypeIds.Research).Sum(a => a.Quantity);
                }
                return _research.Value;
            }
        }

        private static readonly int[] _taxChargeTypeIds = new int[] { (int)ChargeTypeIds.PTMLevy, (int)ChargeTypeIds.Fees, (int)ChargeTypeIds.StampDuty };

        public decimal Taxes
        {
            get
            {
                if (!_research.HasValue)
                {
                    return -Event.Charges.Where(a => _taxChargeTypeIds.Contains( a.ChargeTypeId)).Sum(a => a.Quantity);
                }
                return _research.Value;
            }
        }


        public decimal TotalCommission
        {
            get
            {
                return Research + Commission;
            }
        }

        public decimal TotalOfChargesWithoutCommission
        {
            get
            {
                return TotalOfCharges - TotalCommission;
            }
        }

        public decimal TotalOfChargesWithoutCommissionAndTaxes
        {
            get
            {
                return TotalOfCharges - TotalCommission - Taxes;
            }
        }

    }
}
