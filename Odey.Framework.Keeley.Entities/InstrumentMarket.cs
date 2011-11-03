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
    [KnownType(typeof(Instrument))]
    public partial class InstrumentMarket: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int InstrumentMarketID
        {	
    		
            get { return _instrumentMarketID; }
            set
            {
                if (_instrumentMarketID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'InstrumentMarketID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _instrumentMarketID = value;
                    OnPropertyChanged("InstrumentMarketID");
                }
            }
        }
        private int _instrumentMarketID;
        [DataMember]
        public int InstrumentID
        {	
    		
            get { return _instrumentID; }
            set
            {
                if (_instrumentID != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentID", _instrumentID);
                    if (!IsDeserializing)
                    {
                        if (Instrument != null && Instrument.InstrumentID != value)
                        {
                            Instrument = null;
                        }
                    }
                    _instrumentID = value;
                    OnPropertyChanged("InstrumentID");
                }
            }
        }
        private int _instrumentID;
        [DataMember]
        public int MarketID
        {	
    		
            get { return _marketID; }
            set
            {
                if (_marketID != value)
                {
                    ChangeTracker.RecordOriginalValue("MarketID", _marketID);
                    _marketID = value;
                    OnPropertyChanged("MarketID");
                }
            }
        }
        private int _marketID;
        [DataMember]
        public Nullable<int> FMSecId
        {	
    		
            get { return _fMSecId; }
            set
            {
                if (_fMSecId != value)
                {
                    ChangeTracker.RecordOriginalValue("FMSecId", _fMSecId);
                    _fMSecId = value;
                    OnPropertyChanged("FMSecId");
                }
            }
        }
        private Nullable<int> _fMSecId;
        [DataMember]
        public decimal PriceDivisor
        {	
    		
            get { return _priceDivisor; }
            set
            {
                if (_priceDivisor != value)
                {
                    ChangeTracker.RecordOriginalValue("PriceDivisor", _priceDivisor);
                    _priceDivisor = value;
                    OnPropertyChanged("PriceDivisor");
                }
            }
        }
        private decimal _priceDivisor;
        [DataMember]
        public string BloombergTicker
        {	
    		
            get { return _bloombergTicker; }
            set
            {
                if (_bloombergTicker != value)
                {
                    ChangeTracker.RecordOriginalValue("BloombergTicker", _bloombergTicker);
                    _bloombergTicker = value;
                    OnPropertyChanged("BloombergTicker");
                }
            }
        }
        private string _bloombergTicker;
        [DataMember]
        public string Sedol
        {	
    		
            get { return _sedol; }
            set
            {
                if (_sedol != value)
                {
                    ChangeTracker.RecordOriginalValue("Sedol", _sedol);
                    _sedol = value;
                    OnPropertyChanged("Sedol");
                }
            }
        }
        private string _sedol;
        [DataMember]
        public bool IsPrimary
        {	
    		
            get { return _isPrimary; }
            set
            {
                if (_isPrimary != value)
                {
                    ChangeTracker.RecordOriginalValue("IsPrimary", _isPrimary);
                    _isPrimary = value;
                    OnPropertyChanged("IsPrimary");
                }
            }
        }
        private bool _isPrimary;
        [DataMember]
        public System.DateTime StartDt
        {	
    		
            get { return _startDt; }
            private set
            {
                if (_startDt != value)
                {
                    ChangeTracker.RecordOriginalValue("StartDt", _startDt);
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
                    ChangeTracker.RecordOriginalValue("DataVersion", _dataVersion);
                    _dataVersion = value;
                    OnPropertyChanged("DataVersion");
                }
            }
        }
        private byte[] _dataVersion;
        [DataMember]
        public int PriceCurrencyId
        {	
    		
            get { return _priceCurrencyId; }
            set
            {
                if (_priceCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("PriceCurrencyId", _priceCurrencyId);
                    _priceCurrencyId = value;
                    OnPropertyChanged("PriceCurrencyId");
                }
            }
        }
        private int _priceCurrencyId;
        [DataMember]
        public int ListingStatusId
        {	
    		
            get { return _listingStatusId; }
            set
            {
                if (_listingStatusId != value)
                {
                    ChangeTracker.RecordOriginalValue("ListingStatusId", _listingStatusId);
                    _listingStatusId = value;
                    OnPropertyChanged("ListingStatusId");
                }
            }
        }
        private int _listingStatusId;
        [DataMember]
        public int UnderlyingInstrumentMarketId
        {	
    		
            get { return _underlyingInstrumentMarketId; }
            set
            {
                if (_underlyingInstrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("UnderlyingInstrumentMarketId", _underlyingInstrumentMarketId);
                    _underlyingInstrumentMarketId = value;
                    OnPropertyChanged("UnderlyingInstrumentMarketId");
                }
            }
        }
        private int _underlyingInstrumentMarketId;
        [DataMember]
        public int UltimateUnderlyingInstrumentMarketId
        {	
    		
            get { return _ultimateUnderlyingInstrumentMarketId; }
            set
            {
                if (_ultimateUnderlyingInstrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("UltimateUnderlyingInstrumentMarketId", _ultimateUnderlyingInstrumentMarketId);
                    _ultimateUnderlyingInstrumentMarketId = value;
                    OnPropertyChanged("UltimateUnderlyingInstrumentMarketId");
                }
            }
        }
        private int _ultimateUnderlyingInstrumentMarketId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Instrument Instrument
        {
            get { return _instrument; }
            set
            {
                if (!ReferenceEquals(_instrument, value))
                {
                    var previousValue = _instrument;
                    _instrument = value;
                    FixupInstrument(previousValue);
                    OnNavigationPropertyChanged("Instrument");
                }
            }
        }
        private Instrument _instrument;

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
            Instrument = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupInstrument(Instrument previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.InstrumentMarkets.Contains(this))
            {
                previousValue.InstrumentMarkets.Remove(this);
            }
    
            if (Instrument != null)
            {
                if (!Instrument.InstrumentMarkets.Contains(this))
                {
                    Instrument.InstrumentMarkets.Add(this);
                }
    
                InstrumentID = Instrument.InstrumentID;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Instrument")
                    && (ChangeTracker.OriginalValues["Instrument"] == Instrument))
                {
                    ChangeTracker.OriginalValues.Remove("Instrument");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Instrument", previousValue);
                }
                if (Instrument != null && !Instrument.ChangeTracker.ChangeTrackingEnabled)
                {
                    Instrument.StartTracking();
                }
            }
        }

        #endregion
    }
}
