//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Odey.Framework.Keeley.Entities
{
    [DataContract(IsReference = true)]
    public partial class PortfolioEvent: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PortfolioEventID
        {	
    		
            get { return _portfolioEventID; }
            set
            {
                if (_portfolioEventID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PortfolioEventID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _portfolioEventID = value;
                    OnPropertyChanged("PortfolioEventID");
                }
            }
        }
        private int _portfolioEventID;
        [DataMember]
        public int InternalAllocationId
        {	
    		
            get { return _internalAllocationId; }
            set
            {
                if (_internalAllocationId != value)
                {
                    ChangeTracker.RecordOriginalValue("InternalAllocationId", _internalAllocationId);
                    _internalAllocationId = value;
                    OnPropertyChanged("InternalAllocationId");
                }
            }
        }
        private int _internalAllocationId;
        [DataMember]
        public int PositionId
        {	
    		
            get { return _positionId; }
            set
            {
                if (_positionId != value)
                {
                    ChangeTracker.RecordOriginalValue("PositionId", _positionId);
                    _positionId = value;
                    OnPropertyChanged("PositionId");
                }
            }
        }
        private int _positionId;
        [DataMember]
        public System.DateTime ReferenceDate
        {	
    		
            get { return _referenceDate; }
            set
            {
                if (_referenceDate != value)
                {
                    _referenceDate = value;
                    OnPropertyChanged("ReferenceDate");
                }
            }
        }
        private System.DateTime _referenceDate;
        [DataMember]
        public int PortfolioAggregationLevelId
        {	
    		
            get { return _portfolioAggregationLevelId; }
            set
            {
                if (_portfolioAggregationLevelId != value)
                {
                    ChangeTracker.RecordOriginalValue("PortfolioAggregationLevelId", _portfolioAggregationLevelId);
                    _portfolioAggregationLevelId = value;
                    OnPropertyChanged("PortfolioAggregationLevelId");
                }
            }
        }
        private int _portfolioAggregationLevelId;
        [DataMember]
        public int PortfolioEventTypeId
        {	
    		
            get { return _portfolioEventTypeId; }
            set
            {
                if (_portfolioEventTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("PortfolioEventTypeId", _portfolioEventTypeId);
                    _portfolioEventTypeId = value;
                    OnPropertyChanged("PortfolioEventTypeId");
                }
            }
        }
        private int _portfolioEventTypeId;
        [DataMember]
        public int ChangeNumber
        {	
    		
            get { return _changeNumber; }
            set
            {
                if (_changeNumber != value)
                {
                    _changeNumber = value;
                    OnPropertyChanged("ChangeNumber");
                }
            }
        }
        private int _changeNumber;
        [DataMember]
        public decimal Quantity
        {	
    		
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }
        private decimal _quantity;
        [DataMember]
        public decimal FXRate
        {	
    		
            get { return _fXRate; }
            set
            {
                if (_fXRate != value)
                {
                    _fXRate = value;
                    OnPropertyChanged("FXRate");
                }
            }
        }
        private decimal _fXRate;
        [DataMember]
        public decimal Price
        {	
    		
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        private decimal _price;
        [DataMember]
        public decimal NetCostChangeInstrumentCurrency
        {	
    		
            get { return _netCostChangeInstrumentCurrency; }
            set
            {
                if (_netCostChangeInstrumentCurrency != value)
                {
                    _netCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("NetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _netCostChangeInstrumentCurrency;
        [DataMember]
        public decimal NetCostChangeBookCurrency
        {	
    		
            get { return _netCostChangeBookCurrency; }
            set
            {
                if (_netCostChangeBookCurrency != value)
                {
                    _netCostChangeBookCurrency = value;
                    OnPropertyChanged("NetCostChangeBookCurrency");
                }
            }
        }
        private decimal _netCostChangeBookCurrency;
        [DataMember]
        public decimal NetCostInstrumentCurrency
        {	
    		
            get { return _netCostInstrumentCurrency; }
            set
            {
                if (_netCostInstrumentCurrency != value)
                {
                    _netCostInstrumentCurrency = value;
                    OnPropertyChanged("NetCostInstrumentCurrency");
                }
            }
        }
        private decimal _netCostInstrumentCurrency;
        [DataMember]
        public decimal NetCostBookCurrency
        {	
    		
            get { return _netCostBookCurrency; }
            set
            {
                if (_netCostBookCurrency != value)
                {
                    _netCostBookCurrency = value;
                    OnPropertyChanged("NetCostBookCurrency");
                }
            }
        }
        private decimal _netCostBookCurrency;
        [DataMember]
        public decimal DeltaNetCostChangeInstrumentCurrency
        {	
    		
            get { return _deltaNetCostChangeInstrumentCurrency; }
            set
            {
                if (_deltaNetCostChangeInstrumentCurrency != value)
                {
                    _deltaNetCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("DeltaNetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _deltaNetCostChangeInstrumentCurrency;
        [DataMember]
        public decimal DeltaNetCostChangeBookCurrency
        {	
    		
            get { return _deltaNetCostChangeBookCurrency; }
            set
            {
                if (_deltaNetCostChangeBookCurrency != value)
                {
                    _deltaNetCostChangeBookCurrency = value;
                    OnPropertyChanged("DeltaNetCostChangeBookCurrency");
                }
            }
        }
        private decimal _deltaNetCostChangeBookCurrency;
        [DataMember]
        public decimal DeltaNetCostInstrumentCurrency
        {	
    		
            get { return _deltaNetCostInstrumentCurrency; }
            set
            {
                if (_deltaNetCostInstrumentCurrency != value)
                {
                    _deltaNetCostInstrumentCurrency = value;
                    OnPropertyChanged("DeltaNetCostInstrumentCurrency");
                }
            }
        }
        private decimal _deltaNetCostInstrumentCurrency;
        [DataMember]
        public decimal DeltaNetCostBookCurrency
        {	
    		
            get { return _deltaNetCostBookCurrency; }
            set
            {
                if (_deltaNetCostBookCurrency != value)
                {
                    _deltaNetCostBookCurrency = value;
                    OnPropertyChanged("DeltaNetCostBookCurrency");
                }
            }
        }
        private decimal _deltaNetCostBookCurrency;
        [DataMember]
        public decimal TodayNetPositionChange
        {	
    		
            get { return _todayNetPositionChange; }
            set
            {
                if (_todayNetPositionChange != value)
                {
                    _todayNetPositionChange = value;
                    OnPropertyChanged("TodayNetPositionChange");
                }
            }
        }
        private decimal _todayNetPositionChange;
        [DataMember]
        public decimal TodayDeltaNetCostChangeInstrumentCurrency
        {	
    		
            get { return _todayDeltaNetCostChangeInstrumentCurrency; }
            set
            {
                if (_todayDeltaNetCostChangeInstrumentCurrency != value)
                {
                    _todayDeltaNetCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("TodayDeltaNetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _todayDeltaNetCostChangeInstrumentCurrency;
        [DataMember]
        public decimal TodayDeltaNetCostChangeBookCurrency
        {	
    		
            get { return _todayDeltaNetCostChangeBookCurrency; }
            set
            {
                if (_todayDeltaNetCostChangeBookCurrency != value)
                {
                    _todayDeltaNetCostChangeBookCurrency = value;
                    OnPropertyChanged("TodayDeltaNetCostChangeBookCurrency");
                }
            }
        }
        private decimal _todayDeltaNetCostChangeBookCurrency;
        [DataMember]
        public decimal TodayNetCostChangeInstrumentCurrency
        {	
    		
            get { return _todayNetCostChangeInstrumentCurrency; }
            set
            {
                if (_todayNetCostChangeInstrumentCurrency != value)
                {
                    _todayNetCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("TodayNetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _todayNetCostChangeInstrumentCurrency;
        [DataMember]
        public decimal TodayNetCostChangeBookCurrency
        {	
    		
            get { return _todayNetCostChangeBookCurrency; }
            set
            {
                if (_todayNetCostChangeBookCurrency != value)
                {
                    _todayNetCostChangeBookCurrency = value;
                    OnPropertyChanged("TodayNetCostChangeBookCurrency");
                }
            }
        }
        private decimal _todayNetCostChangeBookCurrency;
        [DataMember]
        public decimal NetPosition
        {	
    		
            get { return _netPosition; }
            set
            {
                if (_netPosition != value)
                {
                    _netPosition = value;
                    OnPropertyChanged("NetPosition");
                }
            }
        }
        private decimal _netPosition;
        [DataMember]
        public System.DateTime StartDt
        {	
    		
            get { return _startDt; }
            private set
            {
                if (_startDt != value)
                {
                    _startDt = value;
                    OnPropertyChanged("StartDt");
                }
            }
        }
        private System.DateTime _startDt;
        [DataMember]
        public int UpdateUserID
        {	
    		
            get { return _updateUserID; }
            private set
            {
                if (_updateUserID != value)
                {
                    ChangeTracker.RecordOriginalValue("UpdateUserID", _updateUserID);
                    _updateUserID = value;
                    OnPropertyChanged("UpdateUserID");
                }
            }
        }
        private int _updateUserID;
        [DataMember]
        private byte[] DataVersion
        {	
    		
            get { return _dataVersion; }
            set
            {
                if (_dataVersion != value)
                {
                    _dataVersion = value;
                    OnPropertyChanged("DataVersion");
                }
            }
        }
        private byte[] _dataVersion;
        [DataMember]
        public System.DateTime InputDate
        {	
    		
            get { return _inputDate; }
            set
            {
                if (_inputDate != value)
                {
                    _inputDate = value;
                    OnPropertyChanged("InputDate");
                }
            }
        }
        private System.DateTime _inputDate;
        [DataMember]
        public int OrderingResolution
        {	
    		
            get { return _orderingResolution; }
            set
            {
                if (_orderingResolution != value)
                {
                    _orderingResolution = value;
                    OnPropertyChanged("OrderingResolution");
                }
            }
        }
        private int _orderingResolution;
        [DataMember]
        public decimal Accrual
        {	
    		
            get { return _accrual; }
            set
            {
                if (_accrual != value)
                {
                    _accrual = value;
                    OnPropertyChanged("Accrual");
                }
            }
        }
        private decimal _accrual;
        [DataMember]
        public decimal TodayAccrual
        {	
    		
            get { return _todayAccrual; }
            set
            {
                if (_todayAccrual != value)
                {
                    _todayAccrual = value;
                    OnPropertyChanged("TodayAccrual");
                }
            }
        }
        private decimal _todayAccrual;
        [DataMember]
        public decimal CashBenefit
        {	
    		
            get { return _cashBenefit; }
            set
            {
                if (_cashBenefit != value)
                {
                    _cashBenefit = value;
                    OnPropertyChanged("CashBenefit");
                }
            }
        }
        private decimal _cashBenefit;
        [DataMember]
        public decimal TodayCashBenefit
        {	
    		
            get { return _todayCashBenefit; }
            set
            {
                if (_todayCashBenefit != value)
                {
                    _todayCashBenefit = value;
                    OnPropertyChanged("TodayCashBenefit");
                }
            }
        }
        private decimal _todayCashBenefit;
        [DataMember]
        public decimal TodayCashBenefitBookCurrency
        {	
    		
            get { return _todayCashBenefitBookCurrency; }
            set
            {
                if (_todayCashBenefitBookCurrency != value)
                {
                    _todayCashBenefitBookCurrency = value;
                    OnPropertyChanged("TodayCashBenefitBookCurrency");
                }
            }
        }
        private decimal _todayCashBenefitBookCurrency;
        [DataMember]
        public decimal RealisedPricePnl
        {	
    		
            get { return _realisedPricePnl; }
            set
            {
                if (_realisedPricePnl != value)
                {
                    _realisedPricePnl = value;
                    OnPropertyChanged("RealisedPricePnl");
                }
            }
        }
        private decimal _realisedPricePnl;
        [DataMember]
        public decimal TodayRealisedPricePnl
        {	
    		
            get { return _todayRealisedPricePnl; }
            set
            {
                if (_todayRealisedPricePnl != value)
                {
                    _todayRealisedPricePnl = value;
                    OnPropertyChanged("TodayRealisedPricePnl");
                }
            }
        }
        private decimal _todayRealisedPricePnl;
        [DataMember]
        public decimal RealisedFxPnl
        {	
    		
            get { return _realisedFxPnl; }
            set
            {
                if (_realisedFxPnl != value)
                {
                    _realisedFxPnl = value;
                    OnPropertyChanged("RealisedFxPnl");
                }
            }
        }
        private decimal _realisedFxPnl;
        [DataMember]
        public decimal TodayRealisedFxPnl
        {	
    		
            get { return _todayRealisedFxPnl; }
            set
            {
                if (_todayRealisedFxPnl != value)
                {
                    _todayRealisedFxPnl = value;
                    OnPropertyChanged("TodayRealisedFxPnl");
                }
            }
        }
        private decimal _todayRealisedFxPnl;
        [DataMember]
        public decimal TotalAccrual
        {	
    		
            get { return _totalAccrual; }
            set
            {
                if (_totalAccrual != value)
                {
                    _totalAccrual = value;
                    OnPropertyChanged("TotalAccrual");
                }
            }
        }
        private decimal _totalAccrual;
        [DataMember]
        public decimal TodayRealisedPricePnlBookCurrency
        {	
    		
            get { return _todayRealisedPricePnlBookCurrency; }
            set
            {
                if (_todayRealisedPricePnlBookCurrency != value)
                {
                    _todayRealisedPricePnlBookCurrency = value;
                    OnPropertyChanged("TodayRealisedPricePnlBookCurrency");
                }
            }
        }
        private decimal _todayRealisedPricePnlBookCurrency;
        [DataMember]
        public bool RealisePnl
        {	
    		
            get { return _realisePnl; }
            set
            {
                if (_realisePnl != value)
                {
                    _realisePnl = value;
                    OnPropertyChanged("RealisePnl");
                }
            }
        }
        private bool _realisePnl;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
    
        protected virtual void ClearNavigationProperties()
        {
        }

        #endregion
    }
}
