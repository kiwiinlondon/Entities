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
    public partial class Event: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int EventID
        {	
    		
            get { return _eventID; }
            set
            {
                if (_eventID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'EventID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _eventID = value;
                    OnPropertyChanged("EventID");
                }
            }
        }
        private int _eventID;
        [DataMember]
        public int EventTypeID
        {	
    		
            get { return _eventTypeID; }
            set
            {
                if (_eventTypeID != value)
                {
                    ChangeTracker.RecordOriginalValue("EventTypeID", _eventTypeID);
                    _eventTypeID = value;
                    OnPropertyChanged("EventTypeID");
                }
            }
        }
        private int _eventTypeID;
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
        public int IdentifierTypeId
        {	
    		
            get { return _identifierTypeId; }
            set
            {
                if (_identifierTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("IdentifierTypeId", _identifierTypeId);
                    _identifierTypeId = value;
                    OnPropertyChanged("IdentifierTypeId");
                }
            }
        }
        private int _identifierTypeId;
        [DataMember]
        public string Identifier
        {	
    		
            get { return _identifier; }
            set
            {
                if (_identifier != value)
                {
                    _identifier = value;
                    OnPropertyChanged("Identifier");
                }
            }
        }
        private string _identifier;
        [DataMember]
        public bool IsTopLevel
        {	
    		
            get { return _isTopLevel; }
            set
            {
                if (_isTopLevel != value)
                {
                    _isTopLevel = value;
                    OnPropertyChanged("IsTopLevel");
                }
            }
        }
        private bool _isTopLevel;

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
