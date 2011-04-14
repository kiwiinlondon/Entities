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
    public partial class PositionAccount: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PositionAccountID
        {	
    		
            get { return _positionAccountID; }
            set
            {
                if (_positionAccountID != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PositionAccountID' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _positionAccountID = value;
                    OnPropertyChanged("PositionAccountID");
                }
            }
        }
        private int _positionAccountID;
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
        public int PositionId
        {	
    		
            get { return _positionId; }
            set
            {
                if (_positionId != value)
                {
                    ChangeTracker.RecordOriginalValue("PositionId", _positionId);
                    _positionId = value;
                    OnPropertyChanged("PositionId");
                }
            }
        }
        private int _positionId;
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
        public int InstrumentMarketID
        {	
    		
            get { return _instrumentMarketID; }
            set
            {
                if (_instrumentMarketID != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentMarketID", _instrumentMarketID);
                    _instrumentMarketID = value;
                    OnPropertyChanged("InstrumentMarketID");
                }
            }
        }
        private int _instrumentMarketID;
        [DataMember]
        public int CurrencyID
        {	
    		
            get { return _currencyID; }
            set
            {
                if (_currencyID != value)
                {
                    ChangeTracker.RecordOriginalValue("CurrencyID", _currencyID);
                    _currencyID = value;
                    OnPropertyChanged("CurrencyID");
                }
            }
        }
        private int _currencyID;

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
