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
    [KnownType(typeof(LegalEntity))]
    public partial class Issuer: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int LegalEntityID
        {	
    		
            get { return _legalEntityID; }
            set
            {
                if (_legalEntityID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'LegalEntityID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    if (!IsDeserializing)
                    {
                        if (LegalEntity != null && LegalEntity.LegalEntityID != value)
                        {
                            LegalEntity = null;
                        }
                    }
                    _legalEntityID = value;
                    OnPropertyChanged("LegalEntityID");
                }
            }
        }
        private int _legalEntityID;
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
        private LegalEntity LegalEntity
        {
            get { return _legalEntity; }
            set
            {
                if (!ReferenceEquals(_legalEntity, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (LegalEntityID != value.LegalEntityID)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _legalEntity;
                    _legalEntity = value;
                    FixupLegalEntity(previousValue);
                    OnNavigationPropertyChanged("LegalEntity");
                }
            }
        }
        private LegalEntity _legalEntity;

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
    
        // This entity type is the dependent end in at least one association that performs cascade deletes.
        // This event handler will process notifications that occur when the principal end is deleted.
        internal void HandleCascadeDelete(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                this.MarkAsDeleted();
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
            LegalEntity = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupLegalEntity(LegalEntity previousValue)
        {
            // This is the dependent end in an association that performs cascade deletes.
            // Update the principal's event listener to refer to the new dependent.
            // This is a unidirectional relationship from the dependent to the principal, so the dependent end is
            // responsible for managing the cascade delete event handler. In all other cases the principal end will manage it.
            if (previousValue != null)
            {
                previousValue.ChangeTracker.ObjectStateChanging -= HandleCascadeDelete;
            }
    
            if (LegalEntity != null)
            {
                LegalEntity.ChangeTracker.ObjectStateChanging += HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (LegalEntity != null)
            {
                LegalEntityID = LegalEntity.LegalEntityID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("LegalEntity")
                    && (ChangeTracker.OriginalValues["LegalEntity"] == LegalEntity))
                {
                    ChangeTracker.OriginalValues.Remove("LegalEntity");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("LegalEntity", previousValue);
                    // This is the dependent end of an identifying association, so it must be deleted when the relationship is
                    // removed. If the current state is Added, the relationship can be changed without causing the dependent to be deleted.
                    // This is a unidirectional relationship from the dependent to the principal, so the dependent end is
                    // responsible for cascading the delete. In all other cases the principal end will manage it.
                    if (previousValue != null && ChangeTracker.State != ObjectState.Added)
                    {
                        this.MarkAsDeleted();
                    }
                }
                if (LegalEntity != null && !LegalEntity.ChangeTracker.ChangeTrackingEnabled)
                {
                    LegalEntity.StartTracking();
                }
            }
        }

        #endregion
    }
}
