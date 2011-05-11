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
    public partial class PortfolioSettlementDate: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PortfolioSettlementDateId
        {	
    		
            get { return _portfolioSettlementDateId; }
            set
            {
                if (_portfolioSettlementDateId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PortfolioSettlementDateId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _portfolioSettlementDateId = value;
                    OnPropertyChanged("PortfolioSettlementDateId");
                }
            }
        }
        private int _portfolioSettlementDateId;
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
        public decimal NetPosition
        {	
    		
            get { return _netPosition; }
            set
            {
                if (_netPosition != value)
                {
                    _netPosition = value;
                    OnPropertyChanged("NetPosition");
                }
            }
        }
        private decimal _netPosition;
        [DataMember]
        public decimal NetCostInstrumentCurrency
        {	
    		
            get { return _netCostInstrumentCurrency; }
            set
            {
                if (_netCostInstrumentCurrency != value)
                {
                    _netCostInstrumentCurrency = value;
                    OnPropertyChanged("NetCostInstrumentCurrency");
                }
            }
        }
        private decimal _netCostInstrumentCurrency;
        [DataMember]
        public decimal NetCostBookCurrency
        {	
    		
            get { return _netCostBookCurrency; }
            set
            {
                if (_netCostBookCurrency != value)
                {
                    _netCostBookCurrency = value;
                    OnPropertyChanged("NetCostBookCurrency");
                }
            }
        }
        private decimal _netCostBookCurrency;
        [DataMember]
        public decimal DeltaNetCostInstrumentCurrency
        {	
    		
            get { return _deltaNetCostInstrumentCurrency; }
            set
            {
                if (_deltaNetCostInstrumentCurrency != value)
                {
                    _deltaNetCostInstrumentCurrency = value;
                    OnPropertyChanged("DeltaNetCostInstrumentCurrency");
                }
            }
        }
        private decimal _deltaNetCostInstrumentCurrency;
        [DataMember]
        public decimal DeltaNetCostBookCurrency
        {	
    		
            get { return _deltaNetCostBookCurrency; }
            set
            {
                if (_deltaNetCostBookCurrency != value)
                {
                    _deltaNetCostBookCurrency = value;
                    OnPropertyChanged("DeltaNetCostBookCurrency");
                }
            }
        }
        private decimal _deltaNetCostBookCurrency;
        [DataMember]
        public decimal TodayNetPostionChange
        {	
    		
            get { return _todayNetPostionChange; }
            set
            {
                if (_todayNetPostionChange != value)
                {
                    _todayNetPostionChange = value;
                    OnPropertyChanged("TodayNetPostionChange");
                }
            }
        }
        private decimal _todayNetPostionChange;
        [DataMember]
        public decimal TodayDeltaNetCostChangeInstrumentCurrency
        {	
    		
            get { return _todayDeltaNetCostChangeInstrumentCurrency; }
            set
            {
                if (_todayDeltaNetCostChangeInstrumentCurrency != value)
                {
                    _todayDeltaNetCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("TodayDeltaNetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _todayDeltaNetCostChangeInstrumentCurrency;
        [DataMember]
        public decimal TodayDeltaNetCostChangeBookCurrency
        {	
    		
            get { return _todayDeltaNetCostChangeBookCurrency; }
            set
            {
                if (_todayDeltaNetCostChangeBookCurrency != value)
                {
                    _todayDeltaNetCostChangeBookCurrency = value;
                    OnPropertyChanged("TodayDeltaNetCostChangeBookCurrency");
                }
            }
        }
        private decimal _todayDeltaNetCostChangeBookCurrency;
        [DataMember]
        public decimal TodayNetCostChangeInstrumentCurrency
        {	
    		
            get { return _todayNetCostChangeInstrumentCurrency; }
            set
            {
                if (_todayNetCostChangeInstrumentCurrency != value)
                {
                    _todayNetCostChangeInstrumentCurrency = value;
                    OnPropertyChanged("TodayNetCostChangeInstrumentCurrency");
                }
            }
        }
        private decimal _todayNetCostChangeInstrumentCurrency;
        [DataMember]
        public decimal TodayNetCostChangeBookCurrency
        {	
    		
            get { return _todayNetCostChangeBookCurrency; }
            set
            {
                if (_todayNetCostChangeBookCurrency != value)
                {
                    _todayNetCostChangeBookCurrency = value;
                    OnPropertyChanged("TodayNetCostChangeBookCurrency");
                }
            }
        }
        private decimal _todayNetCostChangeBookCurrency;
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
