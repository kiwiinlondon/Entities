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
    [KnownType(typeof(Price))]
    public partial class RawPrice: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int RawPriceId
        {	
    		
            get { return _rawPriceId; }
            set
            {
                if (_rawPriceId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'RawPriceId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _rawPriceId = value;
                    OnPropertyChanged("RawPriceId");
                }
            }
        }
        private int _rawPriceId;
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
        public int EntityRankingSchemeItemId
        {	
    		
            get { return _entityRankingSchemeItemId; }
            set
            {
                if (_entityRankingSchemeItemId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityRankingSchemeItemId", _entityRankingSchemeItemId);
                    _entityRankingSchemeItemId = value;
                    OnPropertyChanged("EntityRankingSchemeItemId");
                }
            }
        }
        private int _entityRankingSchemeItemId;
        [DataMember]
        public decimal BidValue
        {	
    		
            get { return _bidValue; }
            set
            {
                if (_bidValue != value)
                {
                    ChangeTracker.RecordOriginalValue("BidValue", _bidValue);
                    _bidValue = value;
                    OnPropertyChanged("BidValue");
                }
            }
        }
        private decimal _bidValue;
        [DataMember]
        public System.DateTime BidUpdateDate
        {	
    		
            get { return _bidUpdateDate; }
            set
            {
                if (_bidUpdateDate != value)
                {
                    ChangeTracker.RecordOriginalValue("BidUpdateDate", _bidUpdateDate);
                    _bidUpdateDate = value;
                    OnPropertyChanged("BidUpdateDate");
                }
            }
        }
        private System.DateTime _bidUpdateDate;
        [DataMember]
        public decimal AskValue
        {	
    		
            get { return _askValue; }
            set
            {
                if (_askValue != value)
                {
                    ChangeTracker.RecordOriginalValue("AskValue", _askValue);
                    _askValue = value;
                    OnPropertyChanged("AskValue");
                }
            }
        }
        private decimal _askValue;
        [DataMember]
        public System.DateTime AskUpdateDate
        {	
    		
            get { return _askUpdateDate; }
            set
            {
                if (_askUpdateDate != value)
                {
                    ChangeTracker.RecordOriginalValue("AskUpdateDate", _askUpdateDate);
                    _askUpdateDate = value;
                    OnPropertyChanged("AskUpdateDate");
                }
            }
        }
        private System.DateTime _askUpdateDate;
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
        public TrackableCollection<Price> Prices
        {
            get
            {
                if (_prices == null)
                {
                    _prices = new TrackableCollection<Price>();
                    _prices.CollectionChanged += FixupPrices;
                }
                return _prices;
            }
            set
            {
                if (!ReferenceEquals(_prices, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_prices != null)
                    {
                        _prices.CollectionChanged -= FixupPrices;
                    }
                    _prices = value;
                    if (_prices != null)
                    {
                        _prices.CollectionChanged += FixupPrices;
                    }
                    OnNavigationPropertyChanged("Prices");
                }
            }
        }
        private TrackableCollection<Price> _prices;

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
            Prices.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupPrices(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Price item in e.NewItems)
                {
                    item.RawPrice = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Prices", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Price item in e.OldItems)
                {
                    if (ReferenceEquals(item.RawPrice, this))
                    {
                        item.RawPrice = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Prices", item);
                    }
                }
            }
        }

        #endregion
    }
}