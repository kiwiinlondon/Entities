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
    [KnownType(typeof(EntityProperty))]
    public partial class ExtractOutputConfiguration: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int ExtractOutputConfigurationID
        {	
    		
            get { return _extractOutputConfigurationID; }
            set
            {
                if (_extractOutputConfigurationID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'ExtractOutputConfigurationID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _extractOutputConfigurationID = value;
                    OnPropertyChanged("ExtractOutputConfigurationID");
                }
            }
        }
        private int _extractOutputConfigurationID;
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
        public string Label
        {	
    		
            get { return _label; }
            set
            {
                if (_label != value)
                {
                    ChangeTracker.RecordOriginalValue("Label", _label);
                    _label = value;
                    OnPropertyChanged("Label");
                }
            }
        }
        private string _label;
        [DataMember]
        public bool ChangesCanBeIgnored
        {	
    		
            get { return _changesCanBeIgnored; }
            set
            {
                if (_changesCanBeIgnored != value)
                {
                    ChangeTracker.RecordOriginalValue("ChangesCanBeIgnored", _changesCanBeIgnored);
                    _changesCanBeIgnored = value;
                    OnPropertyChanged("ChangesCanBeIgnored");
                }
            }
        }
        private bool _changesCanBeIgnored;
        [DataMember]
        public int OrderBy
        {	
    		
            get { return _orderBy; }
            set
            {
                if (_orderBy != value)
                {
                    ChangeTracker.RecordOriginalValue("OrderBy", _orderBy);
                    _orderBy = value;
                    OnPropertyChanged("OrderBy");
                }
            }
        }
        private int _orderBy;
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
        public int EntityPropertyId
        {	
    		
            get { return _entityPropertyId; }
            set
            {
                if (_entityPropertyId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityPropertyId", _entityPropertyId);
                    if (!IsDeserializing)
                    {
                        if (EntityProperty != null && EntityProperty.EntityPropertyID != value)
                        {
                            EntityProperty = null;
                        }
                    }
                    _entityPropertyId = value;
                    OnPropertyChanged("EntityPropertyId");
                }
            }
        }
        private int _entityPropertyId;
        [DataMember]
        public int EntityPropertyToWriteId
        {	
    		
            get { return _entityPropertyToWriteId; }
            set
            {
                if (_entityPropertyToWriteId != value)
                {
                    ChangeTracker.RecordOriginalValue("EntityPropertyToWriteId", _entityPropertyToWriteId);
                    if (!IsDeserializing)
                    {
                        if (EntityPropertyToWrite != null && EntityPropertyToWrite.EntityPropertyID != value)
                        {
                            EntityPropertyToWrite = null;
                        }
                    }
                    _entityPropertyToWriteId = value;
                    OnPropertyChanged("EntityPropertyToWriteId");
                }
            }
        }
        private int _entityPropertyToWriteId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public EntityProperty EntityProperty
        {
            get { return _entityProperty; }
            set
            {
                if (!ReferenceEquals(_entityProperty, value))
                {
                    var previousValue = _entityProperty;
                    _entityProperty = value;
                    FixupEntityProperty(previousValue);
                    OnNavigationPropertyChanged("EntityProperty");
                }
            }
        }
        private EntityProperty _entityProperty;
    
        [DataMember]
        public EntityProperty EntityPropertyToWrite
        {
            get { return _entityPropertyToWrite; }
            set
            {
                if (!ReferenceEquals(_entityPropertyToWrite, value))
                {
                    var previousValue = _entityPropertyToWrite;
                    _entityPropertyToWrite = value;
                    FixupEntityPropertyToWrite(previousValue);
                    OnNavigationPropertyChanged("EntityPropertyToWrite");
                }
            }
        }
        private EntityProperty _entityPropertyToWrite;

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
            EntityProperty = null;
            EntityPropertyToWrite = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupEntityProperty(EntityProperty previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (EntityProperty != null)
            {
                EntityPropertyId = EntityProperty.EntityPropertyID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("EntityProperty")
                    && (ChangeTracker.OriginalValues["EntityProperty"] == EntityProperty))
                {
                    ChangeTracker.OriginalValues.Remove("EntityProperty");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("EntityProperty", previousValue);
                }
                if (EntityProperty != null && !EntityProperty.ChangeTracker.ChangeTrackingEnabled)
                {
                    EntityProperty.StartTracking();
                }
            }
        }
    
        private void FixupEntityPropertyToWrite(EntityProperty previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (EntityPropertyToWrite != null)
            {
                EntityPropertyToWriteId = EntityPropertyToWrite.EntityPropertyID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("EntityPropertyToWrite")
                    && (ChangeTracker.OriginalValues["EntityPropertyToWrite"] == EntityPropertyToWrite))
                {
                    ChangeTracker.OriginalValues.Remove("EntityPropertyToWrite");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("EntityPropertyToWrite", previousValue);
                }
                if (EntityPropertyToWrite != null && !EntityPropertyToWrite.ChangeTracker.ChangeTrackingEnabled)
                {
                    EntityPropertyToWrite.StartTracking();
                }
            }
        }

        #endregion
    }
}
