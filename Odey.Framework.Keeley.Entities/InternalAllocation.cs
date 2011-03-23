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
    [KnownType(typeof(PositionAccountMovement))]
    public partial class InternalAllocation: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int InternalAllocationID
        {	
    		
            get { return _internalAllocationID; }
            set
            {
                if (_internalAllocationID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'InternalAllocationID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _internalAllocationID = value;
                    OnPropertyChanged("InternalAllocationID");
                }
            }
        }
        private int _internalAllocationID;
        [DataMember]
        public int EventID
        {	
    		
            get { return _eventID; }
            set
            {
                if (_eventID != value)
                {
                    ChangeTracker.RecordOriginalValue("EventID", _eventID);
                    _eventID = value;
                    OnPropertyChanged("EventID");
                }
            }
        }
        private int _eventID;
        [DataMember]
        public string FMContEventInd
        {	
    		
            get { return _fMContEventInd; }
            set
            {
                if (_fMContEventInd != value)
                {
                    _fMContEventInd = value;
                    OnPropertyChanged("FMContEventInd");
                }
            }
        }
        private string _fMContEventInd;
        [DataMember]
        public int FMContEventId
        {	
    		
            get { return _fMContEventId; }
            set
            {
                if (_fMContEventId != value)
                {
                    _fMContEventId = value;
                    OnPropertyChanged("FMContEventId");
                }
            }
        }
        private int _fMContEventId;
        [DataMember]
        public int AccountID
        {	
    		
            get { return _accountID; }
            set
            {
                if (_accountID != value)
                {
                    ChangeTracker.RecordOriginalValue("AccountID", _accountID);
                    _accountID = value;
                    OnPropertyChanged("AccountID");
                }
            }
        }
        private int _accountID;
        [DataMember]
        public int BookID
        {	
    		
            get { return _bookID; }
            set
            {
                if (_bookID != value)
                {
                    ChangeTracker.RecordOriginalValue("BookID", _bookID);
                    _bookID = value;
                    OnPropertyChanged("BookID");
                }
            }
        }
        private int _bookID;
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
                    ChangeTracker.RecordOriginalValue("DataVersion", _dataVersion);
                    _dataVersion = value;
                    OnPropertyChanged("DataVersion");
                }
            }
        }
        private byte[] _dataVersion;
        [DataMember]
        public int FMOriginalContEventId
        {	
    		
            get { return _fMOriginalContEventId; }
            set
            {
                if (_fMOriginalContEventId != value)
                {
                    _fMOriginalContEventId = value;
                    OnPropertyChanged("FMOriginalContEventId");
                }
            }
        }
        private int _fMOriginalContEventId;
        [DataMember]
        public bool IsCancelled
        {	
    		
            get { return _isCancelled; }
            set
            {
                if (_isCancelled != value)
                {
                    _isCancelled = value;
                    OnPropertyChanged("IsCancelled");
                }
            }
        }
        private bool _isCancelled;
        [DataMember]
        public int MatchedStatusId
        {	
    		
            get { return _matchedStatusId; }
            set
            {
                if (_matchedStatusId != value)
                {
                    ChangeTracker.RecordOriginalValue("MatchedStatusId", _matchedStatusId);
                    _matchedStatusId = value;
                    OnPropertyChanged("MatchedStatusId");
                }
            }
        }
        private int _matchedStatusId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<PositionAccountMovement> PositionAccountMovements
        {
            get
            {
                if (_positionAccountMovements == null)
                {
                    _positionAccountMovements = new TrackableCollection<PositionAccountMovement>();
                    _positionAccountMovements.CollectionChanged += FixupPositionAccountMovements;
                }
                return _positionAccountMovements;
            }
            set
            {
                if (!ReferenceEquals(_positionAccountMovements, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_positionAccountMovements != null)
                    {
                        _positionAccountMovements.CollectionChanged -= FixupPositionAccountMovements;
                    }
                    _positionAccountMovements = value;
                    if (_positionAccountMovements != null)
                    {
                        _positionAccountMovements.CollectionChanged += FixupPositionAccountMovements;
                    }
                    OnNavigationPropertyChanged("PositionAccountMovements");
                }
            }
        }
        private TrackableCollection<PositionAccountMovement> _positionAccountMovements;

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
            PositionAccountMovements.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupPositionAccountMovements(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (PositionAccountMovement item in e.NewItems)
                {
                    item.InternalAllocationID = InternalAllocationID;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("PositionAccountMovements", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PositionAccountMovement item in e.OldItems)
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("PositionAccountMovements", item);
                    }
                }
            }
        }

        #endregion
    }
}
