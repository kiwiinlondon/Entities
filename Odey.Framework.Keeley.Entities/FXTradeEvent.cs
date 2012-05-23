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
    [KnownType(typeof(Event))]
    [KnownType(typeof(InstrumentMarket))]
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
                    if (!IsDeserializing)
                    {
                        if (Event != null && Event.EventID != value)
                        {
                            Event = null;
                        }
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
                    ChangeTracker.RecordOriginalValue("ReceiveAmount", _receiveAmount);
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
                    ChangeTracker.RecordOriginalValue("PayAmount", _payAmount);
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
                    ChangeTracker.RecordOriginalValue("IsProp", _isProp);
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
                    ChangeTracker.RecordOriginalValue("EnteredMultiply", _enteredMultiply);
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
                    ChangeTracker.RecordOriginalValue("Ticket", _ticket);
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
                    ChangeTracker.RecordOriginalValue("IsCancelled", _isCancelled);
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
                    ChangeTracker.RecordOriginalValue("AmendmentNumber", _amendmentNumber);
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
                    ChangeTracker.RecordOriginalValue("MaturityDate", _maturityDate);
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
        public bool IsForward
        {	
    		
            get { return _isForward; }
            set
            {
                if (_isForward != value)
                {
                    ChangeTracker.RecordOriginalValue("IsForward", _isForward);
                    _isForward = value;
                    OnPropertyChanged("IsForward");
                }
            }
        }
        private bool _isForward;
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
        public bool SupressFromExtracts
        {	
    		
            get { return _supressFromExtracts; }
            set
            {
                if (_supressFromExtracts != value)
                {
                    ChangeTracker.RecordOriginalValue("SupressFromExtracts", _supressFromExtracts);
                    _supressFromExtracts = value;
                    OnPropertyChanged("SupressFromExtracts");
                }
            }
        }
        private bool _supressFromExtracts;
        [DataMember]
        public Nullable<decimal> NonEuroPairReceiveToEuroFXRate
        {	
    		
            get { return _nonEuroPairReceiveToEuroFXRate; }
            set
            {
                if (_nonEuroPairReceiveToEuroFXRate != value)
                {
                    ChangeTracker.RecordOriginalValue("NonEuroPairReceiveToEuroFXRate", _nonEuroPairReceiveToEuroFXRate);
                    _nonEuroPairReceiveToEuroFXRate = value;
                    OnPropertyChanged("NonEuroPairReceiveToEuroFXRate");
                }
            }
        }
        private Nullable<decimal> _nonEuroPairReceiveToEuroFXRate;
        [DataMember]
        public Nullable<int> NonEuroPairReceiveToEuroFXRateId
        {	
    		
            get { return _nonEuroPairReceiveToEuroFXRateId; }
            set
            {
                if (_nonEuroPairReceiveToEuroFXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("NonEuroPairReceiveToEuroFXRateId", _nonEuroPairReceiveToEuroFXRateId);
                    _nonEuroPairReceiveToEuroFXRateId = value;
                    OnPropertyChanged("NonEuroPairReceiveToEuroFXRateId");
                }
            }
        }
        private Nullable<int> _nonEuroPairReceiveToEuroFXRateId;
        [DataMember]
        public bool IsRoll
        {	
    		
            get { return _isRoll; }
            set
            {
                if (_isRoll != value)
                {
                    ChangeTracker.RecordOriginalValue("IsRoll", _isRoll);
                    _isRoll = value;
                    OnPropertyChanged("IsRoll");
                }
            }
        }
        private bool _isRoll;
        [DataMember]
        public Nullable<int> ContraEventId
        {	
    		
            get { return _contraEventId; }
            set
            {
                if (_contraEventId != value)
                {
                    ChangeTracker.RecordOriginalValue("ContraEventId", _contraEventId);
                    _contraEventId = value;
                    OnPropertyChanged("ContraEventId");
                }
            }
        }
        private Nullable<int> _contraEventId;
        [DataMember]
        public int InstrumentMarketId
        {	
    		
            get { return _instrumentMarketId; }
            set
            {
                if (_instrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("InstrumentMarketId", _instrumentMarketId);
                    if (!IsDeserializing)
                    {
                        if (InstrumentMarket != null && InstrumentMarket.InstrumentMarketID != value)
                        {
                            InstrumentMarket = null;
                        }
                    }
                    _instrumentMarketId = value;
                    OnPropertyChanged("InstrumentMarketId");
                }
            }
        }
        private int _instrumentMarketId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Event Event
        {
            get { return _event; }
            set
            {
                if (!ReferenceEquals(_event, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added && value != null)
                    {
                        // This the dependent end of an identifying relationship, so the principal end cannot be changed if it is already set,
                        // otherwise it can only be set to an entity with a primary key that is the same value as the dependent's foreign key.
                        if (EventID != value.EventID)
                        {
                            throw new InvalidOperationException("The principal end of an identifying relationship can only be changed when the dependent end is in the Added state.");
                        }
                    }
                    var previousValue = _event;
                    _event = value;
                    FixupEvent(previousValue);
                    OnNavigationPropertyChanged("Event");
                }
            }
        }
        private Event _event;
    
        [DataMember]
        public InstrumentMarket InstrumentMarket
        {
            get { return _instrumentMarket; }
            set
            {
                if (!ReferenceEquals(_instrumentMarket, value))
                {
                    var previousValue = _instrumentMarket;
                    _instrumentMarket = value;
                    FixupInstrumentMarket(previousValue);
                    OnNavigationPropertyChanged("InstrumentMarket");
                }
            }
        }
        private InstrumentMarket _instrumentMarket;

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
            Event = null;
            InstrumentMarket = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupEvent(Event previousValue)
        {
            // This is the dependent end in an association that performs cascade deletes.
            // Update the principal's event listener to refer to the new dependent.
            // This is a unidirectional relationship from the dependent to the principal, so the dependent end is
            // responsible for managing the cascade delete event handler. In all other cases the principal end will manage it.
            if (previousValue != null)
            {
                previousValue.ChangeTracker.ObjectStateChanging -= HandleCascadeDelete;
            }
    
            if (Event != null)
            {
                Event.ChangeTracker.ObjectStateChanging += HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (Event != null)
            {
                EventID = Event.EventID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Event")
                    && (ChangeTracker.OriginalValues["Event"] == Event))
                {
                    ChangeTracker.OriginalValues.Remove("Event");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Event", previousValue);
                    // This is the dependent end of an identifying association, so it must be deleted when the relationship is
                    // removed. If the current state is Added, the relationship can be changed without causing the dependent to be deleted.
                    // This is a unidirectional relationship from the dependent to the principal, so the dependent end is
                    // responsible for cascading the delete. In all other cases the principal end will manage it.
                    if (previousValue != null && ChangeTracker.State != ObjectState.Added)
                    {
                        this.MarkAsDeleted();
                    }
                }
                if (Event != null && !Event.ChangeTracker.ChangeTrackingEnabled)
                {
                    Event.StartTracking();
                }
            }
        }
    
        private void FixupInstrumentMarket(InstrumentMarket previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (InstrumentMarket != null)
            {
                InstrumentMarketId = InstrumentMarket.InstrumentMarketID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("InstrumentMarket")
                    && (ChangeTracker.OriginalValues["InstrumentMarket"] == InstrumentMarket))
                {
                    ChangeTracker.OriginalValues.Remove("InstrumentMarket");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("InstrumentMarket", previousValue);
                }
                if (InstrumentMarket != null && !InstrumentMarket.ChangeTracker.ChangeTrackingEnabled)
                {
                    InstrumentMarket.StartTracking();
                }
            }
        }

        #endregion
    }
}
