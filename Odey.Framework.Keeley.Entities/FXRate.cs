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
    [KnownType(typeof(RawFXRate))]
    public partial class FXRate: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int FXRateId
        {	
    		
            get { return _fXRateId; }
            set
            {
                if (_fXRateId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'FXRateId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _fXRateId = value;
                    OnPropertyChanged("FXRateId");
                }
            }
        }
        private int _fXRateId;
        [DataMember]
        public int FromCurrencyId
        {	
    		
            get { return _fromCurrencyId; }
            set
            {
                if (_fromCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("FromCurrencyId", _fromCurrencyId);
                    _fromCurrencyId = value;
                    OnPropertyChanged("FromCurrencyId");
                }
            }
        }
        private int _fromCurrencyId;
        [DataMember]
        public int ToCurrencyId
        {	
    		
            get { return _toCurrencyId; }
            set
            {
                if (_toCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("ToCurrencyId", _toCurrencyId);
                    _toCurrencyId = value;
                    OnPropertyChanged("ToCurrencyId");
                }
            }
        }
        private int _toCurrencyId;
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
        public decimal Value
        {	
    		
            get { return _value; }
            set
            {
                if (_value != value)
                {
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
        public int FromRawFXRateId
        {	
    		
            get { return _fromRawFXRateId; }
            set
            {
                if (_fromRawFXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("FromRawFXRateId", _fromRawFXRateId);
                    if (!IsDeserializing)
                    {
                        if (FromRawFXRate != null && FromRawFXRate.RawFXRateId != value)
                        {
                            FromRawFXRate = null;
                        }
                    }
                    _fromRawFXRateId = value;
                    OnPropertyChanged("FromRawFXRateId");
                }
            }
        }
        private int _fromRawFXRateId;
        [DataMember]
        public int ToRawFXRateId
        {	
    		
            get { return _toRawFXRateId; }
            set
            {
                if (_toRawFXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("ToRawFXRateId", _toRawFXRateId);
                    if (!IsDeserializing)
                    {
                        if (ToRawFXRate != null && ToRawFXRate.RawFXRateId != value)
                        {
                            ToRawFXRate = null;
                        }
                    }
                    _toRawFXRateId = value;
                    OnPropertyChanged("ToRawFXRateId");
                }
            }
        }
        private int _toRawFXRateId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public RawFXRate FromRawFXRate
        {
            get { return _fromRawFXRate; }
            set
            {
                if (!ReferenceEquals(_fromRawFXRate, value))
                {
                    var previousValue = _fromRawFXRate;
                    _fromRawFXRate = value;
                    FixupFromRawFXRate(previousValue);
                    OnNavigationPropertyChanged("FromRawFXRate");
                }
            }
        }
        private RawFXRate _fromRawFXRate;
    
        [DataMember]
        public RawFXRate ToRawFXRate
        {
            get { return _toRawFXRate; }
            set
            {
                if (!ReferenceEquals(_toRawFXRate, value))
                {
                    var previousValue = _toRawFXRate;
                    _toRawFXRate = value;
                    FixupToRawFXRate(previousValue);
                    OnNavigationPropertyChanged("ToRawFXRate");
                }
            }
        }
        private RawFXRate _toRawFXRate;

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
            FromRawFXRate = null;
            ToRawFXRate = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupFromRawFXRate(RawFXRate previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.FromFXRates.Contains(this))
            {
                previousValue.FromFXRates.Remove(this);
            }
    
            if (FromRawFXRate != null)
            {
                if (!FromRawFXRate.FromFXRates.Contains(this))
                {
                    FromRawFXRate.FromFXRates.Add(this);
                }
    
                FromRawFXRateId = FromRawFXRate.RawFXRateId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("FromRawFXRate")
                    && (ChangeTracker.OriginalValues["FromRawFXRate"] == FromRawFXRate))
                {
                    ChangeTracker.OriginalValues.Remove("FromRawFXRate");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("FromRawFXRate", previousValue);
                }
                if (FromRawFXRate != null && !FromRawFXRate.ChangeTracker.ChangeTrackingEnabled)
                {
                    FromRawFXRate.StartTracking();
                }
            }
        }
    
        private void FixupToRawFXRate(RawFXRate previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.ToFXRates.Contains(this))
            {
                previousValue.ToFXRates.Remove(this);
            }
    
            if (ToRawFXRate != null)
            {
                if (!ToRawFXRate.ToFXRates.Contains(this))
                {
                    ToRawFXRate.ToFXRates.Add(this);
                }
    
                ToRawFXRateId = ToRawFXRate.RawFXRateId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("ToRawFXRate")
                    && (ChangeTracker.OriginalValues["ToRawFXRate"] == ToRawFXRate))
                {
                    ChangeTracker.OriginalValues.Remove("ToRawFXRate");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("ToRawFXRate", previousValue);
                }
                if (ToRawFXRate != null && !ToRawFXRate.ChangeTracker.ChangeTrackingEnabled)
                {
                    ToRawFXRate.StartTracking();
                }
            }
        }

        #endregion
    }
}
