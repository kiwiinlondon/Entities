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
    [KnownType(typeof(RawPrice))]
    public partial class Price: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PriceId
        {	
    		
            get { return _priceId; }
            set
            {
                if (_priceId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PriceId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _priceId = value;
                    OnPropertyChanged("PriceId");
                }
            }
        }
        private int _priceId;
        [DataMember]
        public int InstrumentMarketId
        {	
    		
            get { return _instrumentMarketId; }
            set
            {
                if (_instrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentMarketId", _instrumentMarketId);
                    _instrumentMarketId = value;
                    OnPropertyChanged("InstrumentMarketId");
                }
            }
        }
        private int _instrumentMarketId;
        [DataMember]
        public System.DateTime ReferenceDate
        {	
    		
            get { return _referenceDate; }
            set
            {
                if (_referenceDate != value)
                {
                    ChangeTracker.RecordOriginalValue("ReferenceDate", _referenceDate);
                    _referenceDate = value;
                    OnPropertyChanged("ReferenceDate");
                }
            }
        }
        private System.DateTime _referenceDate;
        [DataMember]
        public int EntityRankingSchemeId
        {	
    		
            get { return _entityRankingSchemeId; }
            set
            {
                if (_entityRankingSchemeId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityRankingSchemeId", _entityRankingSchemeId);
                    _entityRankingSchemeId = value;
                    OnPropertyChanged("EntityRankingSchemeId");
                }
            }
        }
        private int _entityRankingSchemeId;
        [DataMember]
        public int RawPriceId
        {	
    		
            get { return _rawPriceId; }
            set
            {
                if (_rawPriceId != value)
                {
                    ChangeTracker.RecordOriginalValue("RawPriceId", _rawPriceId);
                    if (!IsDeserializing)
                    {
                        if (RawPrice != null && RawPrice.RawPriceId != value)
                        {
                            RawPrice = null;
                        }
                    }
                    _rawPriceId = value;
                    OnPropertyChanged("RawPriceId");
                }
            }
        }
        private int _rawPriceId;
        [DataMember]
        public decimal Value
        {	
    		
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    ChangeTracker.RecordOriginalValue("Value", _value);
                    _value = value;
                    OnPropertyChanged("Value");
                }
            }
        }
        private decimal _value;
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

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public RawPrice RawPrice
        {
            get { return _rawPrice; }
            set
            {
                if (!ReferenceEquals(_rawPrice, value))
                {
                    var previousValue = _rawPrice;
                    _rawPrice = value;
                    FixupRawPrice(previousValue);
                    OnNavigationPropertyChanged("RawPrice");
                }
            }
        }
        private RawPrice _rawPrice;

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
            RawPrice = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupRawPrice(RawPrice previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Prices.Contains(this))
            {
                previousValue.Prices.Remove(this);
            }
    
            if (RawPrice != null)
            {
                if (!RawPrice.Prices.Contains(this))
                {
                    RawPrice.Prices.Add(this);
                }
    
                RawPriceId = RawPrice.RawPriceId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RawPrice")
                    && (ChangeTracker.OriginalValues["RawPrice"] == RawPrice))
                {
                    ChangeTracker.OriginalValues.Remove("RawPrice");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RawPrice", previousValue);
                }
                if (RawPrice != null && !RawPrice.ChangeTracker.ChangeTrackingEnabled)
                {
                    RawPrice.StartTracking();
                }
            }
        }

        #endregion
    }
}
