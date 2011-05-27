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
    [KnownType(typeof(FXRate))]
    public partial class RawFXRate: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int RawFXRateId
        {	
    		
            get { return _rawFXRateId; }
            set
            {
                if (_rawFXRateId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'RawFXRateId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _rawFXRateId = value;
                    OnPropertyChanged("RawFXRateId");
                }
            }
        }
        private int _rawFXRateId;
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
        public System.DateTime ForwardDate
        {	
    		
            get { return _forwardDate; }
            set
            {
                if (_forwardDate != value)
                {
                    _forwardDate = value;
                    OnPropertyChanged("ForwardDate");
                }
            }
        }
        private System.DateTime _forwardDate;
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
        public int CurrencyId
        {	
    		
            get { return _currencyId; }
            set
            {
                if (_currencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("CurrencyId", _currencyId);
                    _currencyId = value;
                    OnPropertyChanged("CurrencyId");
                }
            }
        }
        private int _currencyId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<FXRate> FromFXRates
        {
            get
            {
                if (_fromFXRates == null)
                {
                    _fromFXRates = new TrackableCollection<FXRate>();
                    _fromFXRates.CollectionChanged += FixupFromFXRates;
                }
                return _fromFXRates;
            }
            set
            {
                if (!ReferenceEquals(_fromFXRates, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_fromFXRates != null)
                    {
                        _fromFXRates.CollectionChanged -= FixupFromFXRates;
                    }
                    _fromFXRates = value;
                    if (_fromFXRates != null)
                    {
                        _fromFXRates.CollectionChanged += FixupFromFXRates;
                    }
                    OnNavigationPropertyChanged("FromFXRates");
                }
            }
        }
        private TrackableCollection<FXRate> _fromFXRates;
    
        [DataMember]
        public TrackableCollection<FXRate> ToFXRates
        {
            get
            {
                if (_toFXRates == null)
                {
                    _toFXRates = new TrackableCollection<FXRate>();
                    _toFXRates.CollectionChanged += FixupToFXRates;
                }
                return _toFXRates;
            }
            set
            {
                if (!ReferenceEquals(_toFXRates, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_toFXRates != null)
                    {
                        _toFXRates.CollectionChanged -= FixupToFXRates;
                    }
                    _toFXRates = value;
                    if (_toFXRates != null)
                    {
                        _toFXRates.CollectionChanged += FixupToFXRates;
                    }
                    OnNavigationPropertyChanged("ToFXRates");
                }
            }
        }
        private TrackableCollection<FXRate> _toFXRates;

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
            FromFXRates.Clear();
            ToFXRates.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupFromFXRates(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FXRate item in e.NewItems)
                {
                    item.FromRawFXRate = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("FromFXRates", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FXRate item in e.OldItems)
                {
                    if (ReferenceEquals(item.FromRawFXRate, this))
                    {
                        item.FromRawFXRate = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("FromFXRates", item);
                    }
                }
            }
        }
    
        private void FixupToFXRates(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (FXRate item in e.NewItems)
                {
                    item.ToRawFXRate = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ToFXRates", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (FXRate item in e.OldItems)
                {
                    if (ReferenceEquals(item.ToRawFXRate, this))
                    {
                        item.ToRawFXRate = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ToFXRates", item);
                    }
                }
            }
        }

        #endregion
    }
}
