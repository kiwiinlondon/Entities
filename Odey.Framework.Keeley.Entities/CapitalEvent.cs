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
    public partial class CapitalEvent: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public System.DateTime TradeDate
        {	
    		
            get { return _tradeDate; }
            set
            {
                if (_tradeDate != value)
                {
                    ChangeTracker.RecordOriginalValue("TradeDate", _tradeDate);
                    _tradeDate = value;
                    OnPropertyChanged("TradeDate");
                }
            }
        }
        private System.DateTime _tradeDate;
        [DataMember]
        public System.DateTime SettlementDate
        {	
    		
            get { return _settlementDate; }
            set
            {
                if (_settlementDate != value)
                {
                    ChangeTracker.RecordOriginalValue("SettlementDate", _settlementDate);
                    _settlementDate = value;
                    OnPropertyChanged("SettlementDate");
                }
            }
        }
        private System.DateTime _settlementDate;
        [DataMember]
        public decimal Quantity
        {	
    		
            get { return _quantity; }
            set
            {
                if (_quantity != value)
                {
                    ChangeTracker.RecordOriginalValue("Quantity", _quantity);
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }
        private decimal _quantity;
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
        public int AmendmentNumber
        {	
    		
            get { return _amendmentNumber; }
            set
            {
                if (_amendmentNumber != value)
                {
                    ChangeTracker.RecordOriginalValue("AmendmentNumber", _amendmentNumber);
                    _amendmentNumber = value;
                    OnPropertyChanged("AmendmentNumber");
                }
            }
        }
        private int _amendmentNumber;
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
        public System.DateTime InputDate
        {	
    		
            get { return _inputDate; }
            set
            {
                if (_inputDate != value)
                {
                    ChangeTracker.RecordOriginalValue("InputDate", _inputDate);
                    _inputDate = value;
                    OnPropertyChanged("InputDate");
                }
            }
        }
        private System.DateTime _inputDate;

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
        }

        #endregion
    }
}
