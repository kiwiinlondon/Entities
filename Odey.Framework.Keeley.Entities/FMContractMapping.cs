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
    public partial class FMContractMapping: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int FMContId
        {	
    		
            get { return _fMContId; }
            set
            {
                if (_fMContId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'FMContId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _fMContId = value;
                    OnPropertyChanged("FMContId");
                }
            }
        }
        private int _fMContId;
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
    
            if (previousValue != null && previousValue.FMContractMappings.Contains(this))
            {
                previousValue.FMContractMappings.Remove(this);
            }
    
            if (Instrument != null)
            {
                if (!Instrument.FMContractMappings.Contains(this))
                {
                    Instrument.FMContractMappings.Add(this);
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
