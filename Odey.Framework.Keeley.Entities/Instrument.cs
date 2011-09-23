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
    [KnownType(typeof(InstrumentRelationship))]
    [KnownType(typeof(EventInstrumentMap))]
    [KnownType(typeof(InstrumentMarket))]
    public partial class Instrument: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int InstrumentID
        {	
    		
            get { return _instrumentID; }
            set
            {
                if (_instrumentID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'InstrumentID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _instrumentID = value;
                    OnPropertyChanged("InstrumentID");
                }
            }
        }
        private int _instrumentID;
        [DataMember]
        public int IssuerID
        {	
    		
            get { return _issuerID; }
            set
            {
                if (_issuerID != value)
                {
                    ChangeTracker.RecordOriginalValue("IssuerID", _issuerID);
                    _issuerID = value;
                    OnPropertyChanged("IssuerID");
                }
            }
        }
        private int _issuerID;
        [DataMember]
        public int InstrumentClassID
        {	
    		
            get { return _instrumentClassID; }
            set
            {
                if (_instrumentClassID != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentClassID", _instrumentClassID);
                    _instrumentClassID = value;
                    OnPropertyChanged("InstrumentClassID");
                }
            }
        }
        private int _instrumentClassID;
        [DataMember]
        public int IssueCurrencyID
        {	
    		
            get { return _issueCurrencyID; }
            set
            {
                if (_issueCurrencyID != value)
                {
                    ChangeTracker.RecordOriginalValue("IssueCurrencyID", _issueCurrencyID);
                    _issueCurrencyID = value;
                    OnPropertyChanged("IssueCurrencyID");
                }
            }
        }
        private int _issueCurrencyID;
        [DataMember]
        public Nullable<int> FMInstId
        {	
    		
            get { return _fMInstId; }
            set
            {
                if (_fMInstId != value)
                {
                    ChangeTracker.RecordOriginalValue("FMInstId", _fMInstId);
                    _fMInstId = value;
                    OnPropertyChanged("FMInstId");
                }
            }
        }
        private Nullable<int> _fMInstId;
        [DataMember]
        public string Name
        {	
    		
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    ChangeTracker.RecordOriginalValue("Name", _name);
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
        [DataMember]
        public string LongName
        {	
    		
            get { return _longName; }
            set
            {
                if (_longName != value)
                {
                    ChangeTracker.RecordOriginalValue("LongName", _longName);
                    _longName = value;
                    OnPropertyChanged("LongName");
                }
            }
        }
        private string _longName;
        [DataMember]
        public string Isin
        {	
    		
            get { return _isin; }
            set
            {
                if (_isin != value)
                {
                    ChangeTracker.RecordOriginalValue("Isin", _isin);
                    _isin = value;
                    OnPropertyChanged("Isin");
                }
            }
        }
        private string _isin;
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
        public InstrumentRelationship UnderlyingRelationship
        {
            get { return _underlyingRelationship; }
            set
            {
                if (!ReferenceEquals(_underlyingRelationship, value))
                {
                    var previousValue = _underlyingRelationship;
                    _underlyingRelationship = value;
                    FixupUnderlyingRelationship(previousValue);
                    OnNavigationPropertyChanged("UnderlyingRelationship");
                }
            }
        }
        private InstrumentRelationship _underlyingRelationship;
    
        [DataMember]
        public EventInstrumentMap EventInstrumentMap
        {
            get { return _eventInstrumentMap; }
            set
            {
                if (!ReferenceEquals(_eventInstrumentMap, value))
                {
                    var previousValue = _eventInstrumentMap;
                    _eventInstrumentMap = value;
                    FixupEventInstrumentMap(previousValue);
                    OnNavigationPropertyChanged("EventInstrumentMap");
                }
            }
        }
        private EventInstrumentMap _eventInstrumentMap;
    
        [DataMember]
        public TrackableCollection<InstrumentMarket> InstrumentMarkets
        {
            get
            {
                if (_instrumentMarkets == null)
                {
                    _instrumentMarkets = new TrackableCollection<InstrumentMarket>();
                    _instrumentMarkets.CollectionChanged += FixupInstrumentMarkets;
                }
                return _instrumentMarkets;
            }
            set
            {
                if (!ReferenceEquals(_instrumentMarkets, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_instrumentMarkets != null)
                    {
                        _instrumentMarkets.CollectionChanged -= FixupInstrumentMarkets;
                    }
                    _instrumentMarkets = value;
                    if (_instrumentMarkets != null)
                    {
                        _instrumentMarkets.CollectionChanged += FixupInstrumentMarkets;
                    }
                    OnNavigationPropertyChanged("InstrumentMarkets");
                }
            }
        }
        private TrackableCollection<InstrumentMarket> _instrumentMarkets;

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
            UnderlyingRelationship = null;
            EventInstrumentMap = null;
            InstrumentMarkets.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupUnderlyingRelationship(InstrumentRelationship previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (UnderlyingRelationship != null)
            {
                ChangeTracker.ObjectStateChanging += UnderlyingRelationship.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (UnderlyingRelationship != null)
            {
                UnderlyingRelationship.OverlyingInstrumentID = InstrumentID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("UnderlyingRelationship")
                    && (ChangeTracker.OriginalValues["UnderlyingRelationship"] == UnderlyingRelationship))
                {
                    ChangeTracker.OriginalValues.Remove("UnderlyingRelationship");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("UnderlyingRelationship", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (UnderlyingRelationship != null && !UnderlyingRelationship.ChangeTracker.ChangeTrackingEnabled)
                {
                    UnderlyingRelationship.StartTracking();
                }
            }
        }
    
        private void FixupEventInstrumentMap(EventInstrumentMap previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (EventInstrumentMap != null)
            {
                ChangeTracker.ObjectStateChanging += EventInstrumentMap.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (EventInstrumentMap != null)
            {
                EventInstrumentMap.InstrumentID = InstrumentID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("EventInstrumentMap")
                    && (ChangeTracker.OriginalValues["EventInstrumentMap"] == EventInstrumentMap))
                {
                    ChangeTracker.OriginalValues.Remove("EventInstrumentMap");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("EventInstrumentMap", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (EventInstrumentMap != null && !EventInstrumentMap.ChangeTracker.ChangeTrackingEnabled)
                {
                    EventInstrumentMap.StartTracking();
                }
            }
        }
    
        private void FixupInstrumentMarkets(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (InstrumentMarket item in e.NewItems)
                {
                    item.Instrument = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("InstrumentMarkets", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (InstrumentMarket item in e.OldItems)
                {
                    if (ReferenceEquals(item.Instrument, this))
                    {
                        item.Instrument = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("InstrumentMarkets", item);
                    }
                }
            }
        }

        #endregion
    }
}
