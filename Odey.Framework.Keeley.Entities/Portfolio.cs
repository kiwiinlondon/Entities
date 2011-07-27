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
    [KnownType(typeof(Position))]
    public partial class Portfolio: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PortfolioId
        {	
    		
            get { return _portfolioId; }
            set
            {
                if (_portfolioId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PortfolioId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _portfolioId = value;
                    OnPropertyChanged("PortfolioId");
                }
            }
        }
        private int _portfolioId;
        [DataMember]
        public int PositionId
        {	
    		
            get { return _positionId; }
            set
            {
                if (_positionId != value)
                {
                    ChangeTracker.RecordOriginalValue("PositionId", _positionId);
                    if (!IsDeserializing)
                    {
                        if (Position != null && Position.PositionId != value)
                        {
                            Position = null;
                        }
                    }
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
        public decimal TodayNetPostionChange
        {	
    		
            get { return _todayNetPostionChange; }
            set
            {
                if (_todayNetPostionChange != value)
                {
                    _todayNetPostionChange = value;
                    OnPropertyChanged("TodayNetPostionChange");
                }
            }
        }
        private decimal _todayNetPostionChange;
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
        public decimal MarketValue
        {	
    		
            get { return _marketValue; }
            set
            {
                if (_marketValue != value)
                {
                    _marketValue = value;
                    OnPropertyChanged("MarketValue");
                }
            }
        }
        private decimal _marketValue;
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
        public Nullable<int> PriceId
        {	
    		
            get { return _priceId; }
            set
            {
                if (_priceId != value)
                {
                    ChangeTracker.RecordOriginalValue("PriceId", _priceId);
                    _priceId = value;
                    OnPropertyChanged("PriceId");
                }
            }
        }
        private Nullable<int> _priceId;
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
        public Nullable<int> FXRateId
        {	
    		
            get { return _fXRateId; }
            set
            {
                if (_fXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("FXRateId", _fXRateId);
                    _fXRateId = value;
                    OnPropertyChanged("FXRateId");
                }
            }
        }
        private Nullable<int> _fXRateId;
        [DataMember]
        public decimal DeltaMarketValue
        {	
    		
            get { return _deltaMarketValue; }
            set
            {
                if (_deltaMarketValue != value)
                {
                    _deltaMarketValue = value;
                    OnPropertyChanged("DeltaMarketValue");
                }
            }
        }
        private decimal _deltaMarketValue;
        [DataMember]
        public decimal TodayUnrealisedFXPnl
        {	
    		
            get { return _todayUnrealisedFXPnl; }
            set
            {
                if (_todayUnrealisedFXPnl != value)
                {
                    _todayUnrealisedFXPnl = value;
                    OnPropertyChanged("TodayUnrealisedFXPnl");
                }
            }
        }
        private decimal _todayUnrealisedFXPnl;
        [DataMember]
        public decimal TodayUnrealisedPricePnl
        {	
    		
            get { return _todayUnrealisedPricePnl; }
            set
            {
                if (_todayUnrealisedPricePnl != value)
                {
                    _todayUnrealisedPricePnl = value;
                    OnPropertyChanged("TodayUnrealisedPricePnl");
                }
            }
        }
        private decimal _todayUnrealisedPricePnl;
        [DataMember]
        public decimal PriceToPositionFXRate
        {	
    		
            get { return _priceToPositionFXRate; }
            set
            {
                if (_priceToPositionFXRate != value)
                {
                    _priceToPositionFXRate = value;
                    OnPropertyChanged("PriceToPositionFXRate");
                }
            }
        }
        private decimal _priceToPositionFXRate;
        [DataMember]
        public Nullable<int> PriceToPositionFXRateId
        {	
    		
            get { return _priceToPositionFXRateId; }
            set
            {
                if (_priceToPositionFXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("PriceToPositionFXRateId", _priceToPositionFXRateId);
                    _priceToPositionFXRateId = value;
                    OnPropertyChanged("PriceToPositionFXRateId");
                }
            }
        }
        private Nullable<int> _priceToPositionFXRateId;
        [DataMember]
        public bool PriceIsLastTradePrice
        {	
    		
            get { return _priceIsLastTradePrice; }
            set
            {
                if (_priceIsLastTradePrice != value)
                {
                    _priceIsLastTradePrice = value;
                    OnPropertyChanged("PriceIsLastTradePrice");
                }
            }
        }
        private bool _priceIsLastTradePrice;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Position Position
        {
            get { return _position; }
            set
            {
                if (!ReferenceEquals(_position, value))
                {
                    var previousValue = _position;
                    _position = value;
                    FixupPosition(previousValue);
                    OnNavigationPropertyChanged("Position");
                }
            }
        }
        private Position _position;

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
            Position = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupPosition(Position previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (Position != null)
            {
                PositionId = Position.PositionId;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Position")
                    && (ChangeTracker.OriginalValues["Position"] == Position))
                {
                    ChangeTracker.OriginalValues.Remove("Position");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Position", previousValue);
                }
                if (Position != null && !Position.ChangeTracker.ChangeTrackingEnabled)
                {
                    Position.StartTracking();
                }
            }
        }

        #endregion
    }
}
