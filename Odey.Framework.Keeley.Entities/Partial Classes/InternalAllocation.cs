using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Odey.Framework.Keeley.Entities.Enums;

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

        #region Is Charge Type Commission
        private bool ChargeIsCommission(Charge charge)
        {
            switch ((ChargeTypeIds)charge.ChargeTypeId)
            {
                case ChargeTypeIds.Commission:
                case ChargeTypeIds.CFDCommission:
                    return true;
                default:
                    return false;
            }
        }
        #endregion 



        #region Total Charges
        private decimal? _totalCommission = null;
        public decimal TotalCommission
        {
            get
            {
                if (!_totalCommission.HasValue)
                {
                    _totalCommission = 0;
                    foreach (Charge charge in Event.Charges)
                    {
                        if (ChargeIsCommission(charge))
                        {
                            _totalCommission = _totalCommission + charge.Quantity;
                        }
                    }
                }
                return _totalCommission.Value;
            }
        }
        #endregion

        #region Total Of Charges Without Commission
        public decimal TotalOfChargesWithoutCommission
        {
            get
            {
                return TotalOfCharges - TotalCommission;
            }
        }
        #endregion
    }
}
