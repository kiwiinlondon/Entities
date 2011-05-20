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
    [KnownType(typeof(InternalAllocation))]
    public partial class FXTradeEvent: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public int ReceiveCurrencyId
        {	
    		
            get { return _receiveCurrencyId; }
            set
            {
                if (_receiveCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("ReceiveCurrencyId", _receiveCurrencyId);
                    _receiveCurrencyId = value;
                    OnPropertyChanged("ReceiveCurrencyId");
                }
            }
        }
        private int _receiveCurrencyId;
        [DataMember]
        public int PayCurrencyId
        {	
    		
            get { return _payCurrencyId; }
            set
            {
                if (_payCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("PayCurrencyId", _payCurrencyId);
                    _payCurrencyId = value;
                    OnPropertyChanged("PayCurrencyId");
                }
            }
        }
        private int _payCurrencyId;
        [DataMember]
        public decimal ReceiveAmount
        {	
    		
            get { return _receiveAmount; }
            set
            {
                if (_receiveAmount != value)
                {
                    _receiveAmount = value;
                    OnPropertyChanged("ReceiveAmount");
                }
            }
        }
        private decimal _receiveAmount;
        [DataMember]
        public decimal PayAmount
        {	
    		
            get { return _payAmount; }
            set
            {
                if (_payAmount != value)
                {
                    _payAmount = value;
                    OnPropertyChanged("PayAmount");
                }
            }
        }
        private decimal _payAmount;
        [DataMember]
        public bool IsProp
        {	
    		
            get { return _isProp; }
            set
            {
                if (_isProp != value)
                {
                    _isProp = value;
                    OnPropertyChanged("IsProp");
                }
            }
        }
        private bool _isProp;
        [DataMember]
        public bool EnteredMultiply
        {	
    		
            get { return _enteredMultiply; }
            set
            {
                if (_enteredMultiply != value)
                {
                    _enteredMultiply = value;
                    OnPropertyChanged("EnteredMultiply");
                }
            }
        }
        private bool _enteredMultiply;
        [DataMember]
        public string Ticket
        {	
    		
            get { return _ticket; }
            set
            {
                if (_ticket != value)
                {
                    _ticket = value;
                    OnPropertyChanged("Ticket");
                }
            }
        }
        private string _ticket;
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
        public int CounterpartyId
        {	
    		
            get { return _counterpartyId; }
            set
            {
                if (_counterpartyId != value)
                {
                    ChangeTracker.RecordOriginalValue("CounterpartyId", _counterpartyId);
                    _counterpartyId = value;
                    OnPropertyChanged("CounterpartyId");
                }
            }
        }
        private int _counterpartyId;
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
        public System.DateTime MaturityDate
        {	
    		
            get { return _maturityDate; }
            set
            {
                if (_maturityDate != value)
                {
                    _maturityDate = value;
                    OnPropertyChanged("MaturityDate");
                }
            }
        }
        private System.DateTime _maturityDate;
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
        public bool IsForward
        {	
    		
            get { return _isForward; }
            set
            {
                if (_isForward != value)
                {
                    _isForward = value;
                    OnPropertyChanged("IsForward");
                }
            }
        }
        private bool _isForward;
        [DataMember]
        public decimal PayBookXrate
        {	
    		
            get { return _payBookXrate; }
            set
            {
                if (_payBookXrate != value)
                {
                    _payBookXrate = value;
                    OnPropertyChanged("PayBookXrate");
                }
            }
        }
        private decimal _payBookXrate;
        [DataMember]
        public decimal ReceiveBookXrate
        {	
    		
            get { return _receiveBookXrate; }
            set
            {
                if (_receiveBookXrate != value)
                {
                    _receiveBookXrate = value;
                    OnPropertyChanged("ReceiveBookXrate");
                }
            }
        }
        private decimal _receiveBookXrate;
        [DataMember]
        public System.DateTime InputDate
        {	
    		
            get { return _inputDate; }
            set
            {
                if (_inputDate != value)
                {
                    _inputDate = value;
                    OnPropertyChanged("InputDate");
                }
            }
        }
        private System.DateTime _inputDate;
        [DataMember]
        public int SettlementCurrencyId
        {	
    		
            get { return _settlementCurrencyId; }
            set
            {
                if (_settlementCurrencyId != value)
                {
                    ChangeTracker.RecordOriginalValue("SettlementCurrencyId", _settlementCurrencyId);
                    _settlementCurrencyId = value;
                    OnPropertyChanged("SettlementCurrencyId");
                }
            }
        }
        private int _settlementCurrencyId;
        [DataMember]
        public decimal SettlementBookXrate
        {	
    		
            get { return _settlementBookXrate; }
            set
            {
                if (_settlementBookXrate != value)
                {
                    _settlementBookXrate = value;
                    OnPropertyChanged("SettlementBookXrate");
                }
            }
        }
        private decimal _settlementBookXrate;
        [DataMember]
        public bool SupressFromExtracts
        {	
    		
            get { return _supressFromExtracts; }
            set
            {
                if (_supressFromExtracts != value)
                {
                    _supressFromExtracts = value;
                    OnPropertyChanged("SupressFromExtracts");
                }
            }
        }
        private bool _supressFromExtracts;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<InternalAllocation> InternalAllocations
        {
            get
            {
                if (_internalAllocations == null)
                {
                    _internalAllocations = new TrackableCollection<InternalAllocation>();
                    _internalAllocations.CollectionChanged += FixupInternalAllocations;
                }
                return _internalAllocations;
            }
            set
            {
                if (!ReferenceEquals(_internalAllocations, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_internalAllocations != null)
                    {
                        _internalAllocations.CollectionChanged -= FixupInternalAllocations;
                    }
                    _internalAllocations = value;
                    if (_internalAllocations != null)
                    {
                        _internalAllocations.CollectionChanged += FixupInternalAllocations;
                    }
                    OnNavigationPropertyChanged("InternalAllocations");
                }
            }
        }
        private TrackableCollection<InternalAllocation> _internalAllocations;

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
            InternalAllocations.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupInternalAllocations(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (InternalAllocation item in e.NewItems)
                {
                    item.ParentEventId = EventID;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("InternalAllocations", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (InternalAllocation item in e.OldItems)
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("InternalAllocations", item);
                    }
                }
            }
        }

        #endregion
    }
}
