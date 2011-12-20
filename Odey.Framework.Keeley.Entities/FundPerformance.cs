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
    [KnownType(typeof(Price))]
    public partial class FundPerformance: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int FundPerformanceId
        {	
    		
            get { return _fundPerformanceId; }
            set
            {
                if (_fundPerformanceId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'FundPerformanceId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _fundPerformanceId = value;
                    OnPropertyChanged("FundPerformanceId");
                }
            }
        }
        private int _fundPerformanceId;
        [DataMember]
        public int FundId
        {	
    		
            get { return _fundId; }
            set
            {
                if (_fundId != value)
                {
                    ChangeTracker.RecordOriginalValue("FundId", _fundId);
                    _fundId = value;
                    OnPropertyChanged("FundId");
                }
            }
        }
        private int _fundId;
        [DataMember]
        public bool IsInception
        {	
    		
            get { return _isInception; }
            set
            {
                if (_isInception != value)
                {
                    ChangeTracker.RecordOriginalValue("IsInception", _isInception);
                    _isInception = value;
                    OnPropertyChanged("IsInception");
                }
            }
        }
        private bool _isInception;
        [DataMember]
        public decimal FundPrice
        {	
    		
            get { return _fundPrice; }
            set
            {
                if (_fundPrice != value)
                {
                    ChangeTracker.RecordOriginalValue("FundPrice", _fundPrice);
                    _fundPrice = value;
                    OnPropertyChanged("FundPrice");
                }
            }
        }
        private decimal _fundPrice;
        [DataMember]
        public int FundPriceId
        {	
    		
            get { return _fundPriceId; }
            set
            {
                if (_fundPriceId != value)
                {
                    ChangeTracker.RecordOriginalValue("FundPriceId", _fundPriceId);
                    _fundPriceId = value;
                    OnPropertyChanged("FundPriceId");
                }
            }
        }
        private int _fundPriceId;
        [DataMember]
        public decimal BenchmarkPrice
        {	
    		
            get { return _benchmarkPrice; }
            set
            {
                if (_benchmarkPrice != value)
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkPrice", _benchmarkPrice);
                    _benchmarkPrice = value;
                    OnPropertyChanged("BenchmarkPrice");
                }
            }
        }
        private decimal _benchmarkPrice;
        [DataMember]
        public int BenchmarkPriceId
        {	
    		
            get { return _benchmarkPriceId; }
            set
            {
                if (_benchmarkPriceId != value)
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkPriceId", _benchmarkPriceId);
                    if (!IsDeserializing)
                    {
                        if (BenchmarkPricePrice != null && BenchmarkPricePrice.PriceId != value)
                        {
                            BenchmarkPricePrice = null;
                        }
                    }
                    _benchmarkPriceId = value;
                    OnPropertyChanged("BenchmarkPriceId");
                }
            }
        }
        private int _benchmarkPriceId;
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
        public System.DateTime ValuationBusinessDate
        {	
    		
            get { return _valuationBusinessDate; }
            set
            {
                if (_valuationBusinessDate != value)
                {
                    ChangeTracker.RecordOriginalValue("ValuationBusinessDate", _valuationBusinessDate);
                    _valuationBusinessDate = value;
                    OnPropertyChanged("ValuationBusinessDate");
                }
            }
        }
        private System.DateTime _valuationBusinessDate;
        [DataMember]
        public System.DateTime ValuationCalandarDate
        {	
    		
            get { return _valuationCalandarDate; }
            set
            {
                if (_valuationCalandarDate != value)
                {
                    ChangeTracker.RecordOriginalValue("ValuationCalandarDate", _valuationCalandarDate);
                    _valuationCalandarDate = value;
                    OnPropertyChanged("ValuationCalandarDate");
                }
            }
        }
        private System.DateTime _valuationCalandarDate;
        [DataMember]
        public System.DateTime ValidUntil
        {	
    		
            get { return _validUntil; }
            set
            {
                if (_validUntil != value)
                {
                    ChangeTracker.RecordOriginalValue("ValidUntil", _validUntil);
                    _validUntil = value;
                    OnPropertyChanged("ValidUntil");
                }
            }
        }
        private System.DateTime _validUntil;
        [DataMember]
        public decimal BenchmarkFundFXRate
        {	
    		
            get { return _benchmarkFundFXRate; }
            set
            {
                if (_benchmarkFundFXRate != value)
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkFundFXRate", _benchmarkFundFXRate);
                    _benchmarkFundFXRate = value;
                    OnPropertyChanged("BenchmarkFundFXRate");
                }
            }
        }
        private decimal _benchmarkFundFXRate;
        [DataMember]
        public Nullable<int> BenchmarkFundFXRateId
        {	
    		
            get { return _benchmarkFundFXRateId; }
            set
            {
                if (_benchmarkFundFXRateId != value)
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkFundFXRateId", _benchmarkFundFXRateId);
                    _benchmarkFundFXRateId = value;
                    OnPropertyChanged("BenchmarkFundFXRateId");
                }
            }
        }
        private Nullable<int> _benchmarkFundFXRateId;
        [DataMember]
        public decimal RiskFreeRate
        {	
    		
            get { return _riskFreeRate; }
            set
            {
                if (_riskFreeRate != value)
                {
                    ChangeTracker.RecordOriginalValue("RiskFreeRate", _riskFreeRate);
                    _riskFreeRate = value;
                    OnPropertyChanged("RiskFreeRate");
                }
            }
        }
        private decimal _riskFreeRate;
        [DataMember]
        public int RiskFreeRatePriceId
        {	
    		
            get { return _riskFreeRatePriceId; }
            set
            {
                if (_riskFreeRatePriceId != value)
                {
                    ChangeTracker.RecordOriginalValue("RiskFreeRatePriceId", _riskFreeRatePriceId);
                    _riskFreeRatePriceId = value;
                    OnPropertyChanged("RiskFreeRatePriceId");
                }
            }
        }
        private int _riskFreeRatePriceId;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public Price BenchmarkPricePrice
        {
            get { return _benchmarkPricePrice; }
            set
            {
                if (!ReferenceEquals(_benchmarkPricePrice, value))
                {
                    var previousValue = _benchmarkPricePrice;
                    _benchmarkPricePrice = value;
                    FixupBenchmarkPricePrice(previousValue);
                    OnNavigationPropertyChanged("BenchmarkPricePrice");
                }
            }
        }
        private Price _benchmarkPricePrice;

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
            BenchmarkPricePrice = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupBenchmarkPricePrice(Price previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (BenchmarkPricePrice != null)
            {
                BenchmarkPriceId = BenchmarkPricePrice.PriceId;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("BenchmarkPricePrice")
                    && (ChangeTracker.OriginalValues["BenchmarkPricePrice"] == BenchmarkPricePrice))
                {
                    ChangeTracker.OriginalValues.Remove("BenchmarkPricePrice");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("BenchmarkPricePrice", previousValue);
                }
                if (BenchmarkPricePrice != null && !BenchmarkPricePrice.ChangeTracker.ChangeTrackingEnabled)
                {
                    BenchmarkPricePrice.StartTracking();
                }
            }
        }

        #endregion
    }
}
