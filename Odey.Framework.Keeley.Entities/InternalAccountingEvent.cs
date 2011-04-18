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
    [KnownType(typeof(Currency))]
    public partial class InternalAccountingEvent: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public int InternalAccountingEventTypeId
        {	
    		
            get { return _internalAccountingEventTypeId; }
            set
            {
                if (_internalAccountingEventTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("InternalAccountingEventTypeId", _internalAccountingEventTypeId);
                    _internalAccountingEventTypeId = value;
                    OnPropertyChanged("InternalAccountingEventTypeId");
                }
            }
        }
        private int _internalAccountingEventTypeId;
        [DataMember]
        public System.DateTime TradeDate
        {	
    		
            get { return _tradeDate; }
            set
            {
                if (_tradeDate != value)
                {
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
                    _settlementDate = value;
                    OnPropertyChanged("SettlementDate");
                }
            }
        }
        private System.DateTime _settlementDate;
        [DataMember]
        public int TraderId
        {	
    		
            get { return _traderId; }
            set
            {
                if (_traderId != value)
                {
                    ChangeTracker.RecordOriginalValue("TraderId", _traderId);
                    _traderId = value;
                    OnPropertyChanged("TraderId");
                }
            }
        }
        private int _traderId;
        [DataMember]
        public decimal NetPrice
        {	
    		
            get { return _netPrice; }
            set
            {
                if (_netPrice != value)
                {
                    _netPrice = value;
                    OnPropertyChanged("NetPrice");
                }
            }
        }
        private decimal _netPrice;
        [DataMember]
        public decimal GrossPrice
        {	
    		
            get { return _grossPrice; }
            set
            {
                if (_grossPrice != value)
                {
                    _grossPrice = value;
                    OnPropertyChanged("GrossPrice");
                }
            }
        }
        private decimal _grossPrice;
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
        public decimal NetConsideration
        {	
    		
            get { return _netConsideration; }
            set
            {
                if (_netConsideration != value)
                {
                    _netConsideration = value;
                    OnPropertyChanged("NetConsideration");
                }
            }
        }
        private decimal _netConsideration;
        [DataMember]
        public decimal InstrumentBookFXRate
        {	
    		
            get { return _instrumentBookFXRate; }
            set
            {
                if (_instrumentBookFXRate != value)
                {
                    _instrumentBookFXRate = value;
                    OnPropertyChanged("InstrumentBookFXRate");
                }
            }
        }
        private decimal _instrumentBookFXRate;
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
        public int AmendmentNumber
        {	
    		
            get { return _amendmentNumber; }
            set
            {
                if (_amendmentNumber != value)
                {
                    _amendmentNumber = value;
                    OnPropertyChanged("AmendmentNumber");
                }
            }
        }
        private int _amendmentNumber;
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
        public int SettlementCurrencyId
        {	
    		
            get { return _settlementCurrencyId; }
            set
            {
                if (_settlementCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("SettlementCurrencyId", _settlementCurrencyId);
                    if (!IsDeserializing)
                    {
                        if (Currency != null && Currency.InstrumentID != value)
                        {
                            Currency = null;
                        }
                    }
                    _settlementCurrencyId = value;
                    OnPropertyChanged("SettlementCurrencyId");
                }
            }
        }
        private int _settlementCurrencyId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Currency Currency
        {
            get { return _currency; }
            set
            {
                if (!ReferenceEquals(_currency, value))
                {
                    var previousValue = _currency;
                    _currency = value;
                    FixupCurrency(previousValue);
                    OnNavigationPropertyChanged("Currency");
                }
            }
        }
        private Currency _currency;

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
            Currency = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupCurrency(Currency previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (Currency != null)
            {
                SettlementCurrencyId = Currency.InstrumentID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Currency")
                    && (ChangeTracker.OriginalValues["Currency"] == Currency))
                {
                    ChangeTracker.OriginalValues.Remove("Currency");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Currency", previousValue);
                }
                if (Currency != null && !Currency.ChangeTracker.ChangeTrackingEnabled)
                {
                    Currency.StartTracking();
                }
            }
        }

        #endregion
    }
}
