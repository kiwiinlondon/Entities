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
    [KnownType(typeof(ExtractEntityPropertyValue))]
    public partial class ExtractEntity: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int ExtractEntityID
        {	
    		
            get { return _extractEntityID; }
            set
            {
                if (_extractEntityID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ExtractEntityID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _extractEntityID = value;
                    OnPropertyChanged("ExtractEntityID");
                }
            }
        }
        private int _extractEntityID;
        [DataMember]
        public int ExtractId
        {	
    		
            get { return _extractId; }
            set
            {
                if (_extractId != value)
                {
                    ChangeTracker.RecordOriginalValue("ExtractId", _extractId);
                    _extractId = value;
                    OnPropertyChanged("ExtractId");
                }
            }
        }
        private int _extractId;
        [DataMember]
        public int EntityId
        {	
    		
            get { return _entityId; }
            set
            {
                if (_entityId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityId", _entityId);
                    _entityId = value;
                    OnPropertyChanged("EntityId");
                }
            }
        }
        private int _entityId;
        [DataMember]
        public Nullable<int> LastSentInExtractRunId
        {	
    		
            get { return _lastSentInExtractRunId; }
            set
            {
                if (_lastSentInExtractRunId != value)
                {
                    ChangeTracker.RecordOriginalValue("LastSentInExtractRunId", _lastSentInExtractRunId);
                    _lastSentInExtractRunId = value;
                    OnPropertyChanged("LastSentInExtractRunId");
                }
            }
        }
        private Nullable<int> _lastSentInExtractRunId;
        [DataMember]
        public bool IsCancelled
        {	
    		
            get { return _isCancelled; }
            set
            {
                if (_isCancelled != value)
                {
                    ChangeTracker.RecordOriginalValue("IsCancelled", _isCancelled);
                    _isCancelled = value;
                    OnPropertyChanged("IsCancelled");
                }
            }
        }
        private bool _isCancelled;
        [DataMember]
        public bool SendInNextRun
        {	
    		
            get { return _sendInNextRun; }
            set
            {
                if (_sendInNextRun != value)
                {
                    ChangeTracker.RecordOriginalValue("SendInNextRun", _sendInNextRun);
                    _sendInNextRun = value;
                    OnPropertyChanged("SendInNextRun");
                }
            }
        }
        private bool _sendInNextRun;
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
        public int EntityTypeId
        {	
    		
            get { return _entityTypeId; }
            set
            {
                if (_entityTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityTypeId", _entityTypeId);
                    _entityTypeId = value;
                    OnPropertyChanged("EntityTypeId");
                }
            }
        }
        private int _entityTypeId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<ExtractEntityPropertyValue> ExtractEntityPropertyValues
        {
            get
            {
                if (_extractEntityPropertyValues == null)
                {
                    _extractEntityPropertyValues = new TrackableCollection<ExtractEntityPropertyValue>();
                    _extractEntityPropertyValues.CollectionChanged += FixupExtractEntityPropertyValues;
                }
                return _extractEntityPropertyValues;
            }
            set
            {
                if (!ReferenceEquals(_extractEntityPropertyValues, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_extractEntityPropertyValues != null)
                    {
                        _extractEntityPropertyValues.CollectionChanged -= FixupExtractEntityPropertyValues;
                    }
                    _extractEntityPropertyValues = value;
                    if (_extractEntityPropertyValues != null)
                    {
                        _extractEntityPropertyValues.CollectionChanged += FixupExtractEntityPropertyValues;
                    }
                    OnNavigationPropertyChanged("ExtractEntityPropertyValues");
                }
            }
        }
        private TrackableCollection<ExtractEntityPropertyValue> _extractEntityPropertyValues;

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
            ExtractEntityPropertyValues.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupExtractEntityPropertyValues(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (ExtractEntityPropertyValue item in e.NewItems)
                {
                    item.ExtractEntityID = ExtractEntityID;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("ExtractEntityPropertyValues", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ExtractEntityPropertyValue item in e.OldItems)
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("ExtractEntityPropertyValues", item);
                    }
                }
            }
        }

        #endregion
    }
}
