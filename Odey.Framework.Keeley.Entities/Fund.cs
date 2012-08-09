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
    [KnownType(typeof(InstrumentMarket))]
    [KnownType(typeof(DealingDateDefinition))]
    [KnownType(typeof(Fund))]
    public partial class Fund: IObjectWithChangeTracker, INotifyPropertyChanged
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
        public bool PositionsExist
        {	
    		
            get { return _positionsExist; }
            set
            {
                if (_positionsExist != value)
                {
                    ChangeTracker.RecordOriginalValue("PositionsExist", _positionsExist);
                    _positionsExist = value;
                    OnPropertyChanged("PositionsExist");
                }
            }
        }
        private bool _positionsExist;
        [DataMember]
        public string PerfFundName
        {	
    		
            get { return _perfFundName; }
            set
            {
                if (_perfFundName != value)
                {
                    ChangeTracker.RecordOriginalValue("PerfFundName", _perfFundName);
                    _perfFundName = value;
                    OnPropertyChanged("PerfFundName");
                }
            }
        }
        private string _perfFundName;
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
                        if (RiskFreeInstrumentMarket != null && RiskFreeInstrumentMarket.InstrumentMarketID != value)
                        {
                            RiskFreeInstrumentMarket = null;
                        }
                    }
                    _instrumentMarketId = value;
                    OnPropertyChanged("InstrumentMarketId");
                }
            }
        }
        private int _instrumentMarketId;
        [DataMember]
        public int BenchmarkInstrumentMarketId
        {	
    		
            get { return _benchmarkInstrumentMarketId; }
            set
            {
                if (_benchmarkInstrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkInstrumentMarketId", _benchmarkInstrumentMarketId);
                    if (!IsDeserializing)
                    {
                        if (BenchmarkInstrumentMarket != null && BenchmarkInstrumentMarket.InstrumentMarketID != value)
                        {
                            BenchmarkInstrumentMarket = null;
                        }
                    }
                    _benchmarkInstrumentMarketId = value;
                    OnPropertyChanged("BenchmarkInstrumentMarketId");
                }
            }
        }
        private int _benchmarkInstrumentMarketId;
        [DataMember]
        public Nullable<int> ParentFundId
        {	
    		
            get { return _parentFundId; }
            set
            {
                if (_parentFundId != value)
                {
                    ChangeTracker.RecordOriginalValue("ParentFundId", _parentFundId);
                    _parentFundId = value;
                    OnPropertyChanged("ParentFundId");
                }
            }
        }
        private Nullable<int> _parentFundId;
        [DataMember]
        public bool IsActive
        {	
    		
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    ChangeTracker.RecordOriginalValue("IsActive", _isActive);
                    _isActive = value;
                    OnPropertyChanged("IsActive");
                }
            }
        }
        private bool _isActive;
        [DataMember]
        public int FundTypeId
        {	
    		
            get { return _fundTypeId; }
            set
            {
                if (_fundTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("FundTypeId", _fundTypeId);
                    _fundTypeId = value;
                    OnPropertyChanged("FundTypeId");
                }
            }
        }
        private int _fundTypeId;
        [DataMember]
        public System.DateTime InceptionDate
        {	
    		
            get { return _inceptionDate; }
            set
            {
                if (_inceptionDate != value)
                {
                    ChangeTracker.RecordOriginalValue("InceptionDate", _inceptionDate);
                    _inceptionDate = value;
                    OnPropertyChanged("InceptionDate");
                }
            }
        }
        private System.DateTime _inceptionDate;
        [DataMember]
        public int RiskFreeInstrumentMarketId
        {	
    		
            get { return _riskFreeInstrumentMarketId; }
            set
            {
                if (_riskFreeInstrumentMarketId != value)
                {
                    ChangeTracker.RecordOriginalValue("RiskFreeInstrumentMarketId", _riskFreeInstrumentMarketId);
                    _riskFreeInstrumentMarketId = value;
                    OnPropertyChanged("RiskFreeInstrumentMarketId");
                }
            }
        }
        private int _riskFreeInstrumentMarketId;
        [DataMember]
        public int DealingDateDefinitionId
        {	
    		
            get { return _dealingDateDefinitionId; }
            set
            {
                if (_dealingDateDefinitionId != value)
                {
                    ChangeTracker.RecordOriginalValue("DealingDateDefinitionId", _dealingDateDefinitionId);
                    if (!IsDeserializing)
                    {
                        if (DealingDateDefinition != null && DealingDateDefinition.DealingDateDefinitionId != value)
                        {
                            DealingDateDefinition = null;
                        }
                    }
                    _dealingDateDefinitionId = value;
                    OnPropertyChanged("DealingDateDefinitionId");
                }
            }
        }
        private int _dealingDateDefinitionId;
        [DataMember]
        public string EZEIdentifier
        {	
    		
            get { return _eZEIdentifier; }
            set
            {
                if (_eZEIdentifier != value)
                {
                    ChangeTracker.RecordOriginalValue("EZEIdentifier", _eZEIdentifier);
                    _eZEIdentifier = value;
                    OnPropertyChanged("EZEIdentifier");
                }
            }
        }
        private string _eZEIdentifier;
        [DataMember]
        public bool PriceIsExternallyVisible
        {	
    		
            get { return _priceIsExternallyVisible; }
            set
            {
                if (_priceIsExternallyVisible != value)
                {
                    ChangeTracker.RecordOriginalValue("PriceIsExternallyVisible", _priceIsExternallyVisible);
                    _priceIsExternallyVisible = value;
                    OnPropertyChanged("PriceIsExternallyVisible");
                }
            }
        }
        private bool _priceIsExternallyVisible;
        [DataMember]
        public bool PortfolioIsExternallyVisible
        {	
    		
            get { return _portfolioIsExternallyVisible; }
            set
            {
                if (_portfolioIsExternallyVisible != value)
                {
                    ChangeTracker.RecordOriginalValue("PortfolioIsExternallyVisible", _portfolioIsExternallyVisible);
                    _portfolioIsExternallyVisible = value;
                    OnPropertyChanged("PortfolioIsExternallyVisible");
                }
            }
        }
        private bool _portfolioIsExternallyVisible;
        [DataMember]
        public int AssetManagementCompanyId
        {	
    		
            get { return _assetManagementCompanyId; }
            set
            {
                if (_assetManagementCompanyId != value)
                {
                    ChangeTracker.RecordOriginalValue("AssetManagementCompanyId", _assetManagementCompanyId);
                    _assetManagementCompanyId = value;
                    OnPropertyChanged("AssetManagementCompanyId");
                }
            }
        }
        private int _assetManagementCompanyId;
        [DataMember]
        public Nullable<int> IntranetOrdering
        {	
    		
            get { return _intranetOrdering; }
            set
            {
                if (_intranetOrdering != value)
                {
                    ChangeTracker.RecordOriginalValue("IntranetOrdering", _intranetOrdering);
                    _intranetOrdering = value;
                    OnPropertyChanged("IntranetOrdering");
                }
            }
        }
        private Nullable<int> _intranetOrdering;
        [DataMember]
        public Nullable<int> ReferenceFundId
        {	
    		
            get { return _referenceFundId; }
            set
            {
                if (_referenceFundId != value)
                {
                    ChangeTracker.RecordOriginalValue("ReferenceFundId", _referenceFundId);
                    if (!IsDeserializing)
                    {
                        if (Fund3 != null && Fund3.LegalEntityID != value)
                        {
                            Fund3 = null;
                        }
                    }
                    _referenceFundId = value;
                    OnPropertyChanged("ReferenceFundId");
                }
            }
        }
        private Nullable<int> _referenceFundId;
        [DataMember]
        public int PerformanceFeeTypeId
        {	
    		
            get { return _performanceFeeTypeId; }
            set
            {
                if (_performanceFeeTypeId != value)
                {
                    ChangeTracker.RecordOriginalValue("PerformanceFeeTypeId", _performanceFeeTypeId);
                    _performanceFeeTypeId = value;
                    OnPropertyChanged("PerformanceFeeTypeId");
                }
            }
        }
        private int _performanceFeeTypeId;
        [DataMember]
        public Nullable<decimal> LossWarning
        {	
    		
            get { return _lossWarning; }
            set
            {
                if (_lossWarning != value)
                {
                    ChangeTracker.RecordOriginalValue("LossWarning", _lossWarning);
                    _lossWarning = value;
                    OnPropertyChanged("LossWarning");
                }
            }
        }
        private Nullable<decimal> _lossWarning;
        [DataMember]
        public Nullable<decimal> LossTrigger
        {	
    		
            get { return _lossTrigger; }
            set
            {
                if (_lossTrigger != value)
                {
                    ChangeTracker.RecordOriginalValue("LossTrigger", _lossTrigger);
                    _lossTrigger = value;
                    OnPropertyChanged("LossTrigger");
                }
            }
        }
        private Nullable<decimal> _lossTrigger;

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
    
        [DataMember]
        public InstrumentMarket BenchmarkInstrumentMarket
        {
            get { return _benchmarkInstrumentMarket; }
            set
            {
                if (!ReferenceEquals(_benchmarkInstrumentMarket, value))
                {
                    var previousValue = _benchmarkInstrumentMarket;
                    _benchmarkInstrumentMarket = value;
                    FixupBenchmarkInstrumentMarket(previousValue);
                    OnNavigationPropertyChanged("BenchmarkInstrumentMarket");
                }
            }
        }
        private InstrumentMarket _benchmarkInstrumentMarket;
    
        [DataMember]
        public DealingDateDefinition DealingDateDefinition
        {
            get { return _dealingDateDefinition; }
            set
            {
                if (!ReferenceEquals(_dealingDateDefinition, value))
                {
                    var previousValue = _dealingDateDefinition;
                    _dealingDateDefinition = value;
                    FixupDealingDateDefinition(previousValue);
                    OnNavigationPropertyChanged("DealingDateDefinition");
                }
            }
        }
        private DealingDateDefinition _dealingDateDefinition;
    
        [DataMember]
        public InstrumentMarket RiskFreeInstrumentMarket
        {
            get { return _riskFreeInstrumentMarket; }
            set
            {
                if (!ReferenceEquals(_riskFreeInstrumentMarket, value))
                {
                    var previousValue = _riskFreeInstrumentMarket;
                    _riskFreeInstrumentMarket = value;
                    FixupRiskFreeInstrumentMarket(previousValue);
                    OnNavigationPropertyChanged("RiskFreeInstrumentMarket");
                }
            }
        }
        private InstrumentMarket _riskFreeInstrumentMarket;
    
        [DataMember]
        public TrackableCollection<Fund> Fund11
        {
            get
            {
                if (_fund11 == null)
                {
                    _fund11 = new TrackableCollection<Fund>();
                    _fund11.CollectionChanged += FixupFund11;
                }
                return _fund11;
            }
            set
            {
                if (!ReferenceEquals(_fund11, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_fund11 != null)
                    {
                        _fund11.CollectionChanged -= FixupFund11;
                    }
                    _fund11 = value;
                    if (_fund11 != null)
                    {
                        _fund11.CollectionChanged += FixupFund11;
                    }
                    OnNavigationPropertyChanged("Fund11");
                }
            }
        }
        private TrackableCollection<Fund> _fund11;
    
        [DataMember]
        public Fund Fund3
        {
            get { return _fund3; }
            set
            {
                if (!ReferenceEquals(_fund3, value))
                {
                    var previousValue = _fund3;
                    _fund3 = value;
                    FixupFund3(previousValue);
                    OnNavigationPropertyChanged("Fund3");
                }
            }
        }
        private Fund _fund3;

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
            InstrumentMarket = null;
            BenchmarkInstrumentMarket = null;
            DealingDateDefinition = null;
            RiskFreeInstrumentMarket = null;
            Fund11.Clear();
            Fund3 = null;
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
    
        private void FixupBenchmarkInstrumentMarket(InstrumentMarket previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (BenchmarkInstrumentMarket != null)
            {
                BenchmarkInstrumentMarketId = BenchmarkInstrumentMarket.InstrumentMarketID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BenchmarkInstrumentMarket")
                    && (ChangeTracker.OriginalValues["BenchmarkInstrumentMarket"] == BenchmarkInstrumentMarket))
                {
                    ChangeTracker.OriginalValues.Remove("BenchmarkInstrumentMarket");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkInstrumentMarket", previousValue);
                }
                if (BenchmarkInstrumentMarket != null && !BenchmarkInstrumentMarket.ChangeTracker.ChangeTrackingEnabled)
                {
                    BenchmarkInstrumentMarket.StartTracking();
                }
            }
        }
    
        private void FixupDealingDateDefinition(DealingDateDefinition previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Funds.Contains(this))
            {
                previousValue.Funds.Remove(this);
            }
    
            if (DealingDateDefinition != null)
            {
                if (!DealingDateDefinition.Funds.Contains(this))
                {
                    DealingDateDefinition.Funds.Add(this);
                }
    
                DealingDateDefinitionId = DealingDateDefinition.DealingDateDefinitionId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("DealingDateDefinition")
                    && (ChangeTracker.OriginalValues["DealingDateDefinition"] == DealingDateDefinition))
                {
                    ChangeTracker.OriginalValues.Remove("DealingDateDefinition");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("DealingDateDefinition", previousValue);
                }
                if (DealingDateDefinition != null && !DealingDateDefinition.ChangeTracker.ChangeTrackingEnabled)
                {
                    DealingDateDefinition.StartTracking();
                }
            }
        }
    
        private void FixupRiskFreeInstrumentMarket(InstrumentMarket previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (RiskFreeInstrumentMarket != null)
            {
                InstrumentMarketId = RiskFreeInstrumentMarket.InstrumentMarketID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("RiskFreeInstrumentMarket")
                    && (ChangeTracker.OriginalValues["RiskFreeInstrumentMarket"] == RiskFreeInstrumentMarket))
                {
                    ChangeTracker.OriginalValues.Remove("RiskFreeInstrumentMarket");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("RiskFreeInstrumentMarket", previousValue);
                }
                if (RiskFreeInstrumentMarket != null && !RiskFreeInstrumentMarket.ChangeTracker.ChangeTrackingEnabled)
                {
                    RiskFreeInstrumentMarket.StartTracking();
                }
            }
        }
    
        private void FixupFund3(Fund previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Fund11.Contains(this))
            {
                previousValue.Fund11.Remove(this);
            }
    
            if (Fund3 != null)
            {
                if (!Fund3.Fund11.Contains(this))
                {
                    Fund3.Fund11.Add(this);
                }
    
                ReferenceFundId = Fund3.LegalEntityID;
            }
            else if (!skipKeys)
            {
                ReferenceFundId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Fund3")
                    && (ChangeTracker.OriginalValues["Fund3"] == Fund3))
                {
                    ChangeTracker.OriginalValues.Remove("Fund3");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Fund3", previousValue);
                }
                if (Fund3 != null && !Fund3.ChangeTracker.ChangeTrackingEnabled)
                {
                    Fund3.StartTracking();
                }
            }
        }
    
        private void FixupFund11(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Fund item in e.NewItems)
                {
                    item.Fund3 = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Fund11", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Fund item in e.OldItems)
                {
                    if (ReferenceEquals(item.Fund3, this))
                    {
                        item.Fund3 = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Fund11", item);
                    }
                }
            }
        }

        #endregion
    }
}
