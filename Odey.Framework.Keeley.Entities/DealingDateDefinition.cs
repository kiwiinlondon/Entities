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
    [KnownType(typeof(Periodicity))]
    [KnownType(typeof(Fund))]
    public partial class DealingDateDefinition: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int DealingDateDefinitionId
        {	
    		
            get { return _dealingDateDefinitionId; }
            set
            {
                if (_dealingDateDefinitionId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'DealingDateDefinitionId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _dealingDateDefinitionId = value;
                    OnPropertyChanged("DealingDateDefinitionId");
                }
            }
        }
        private int _dealingDateDefinitionId;
        [DataMember]
        public string Name
        {	
    		
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    ChangeTracker.RecordOriginalValue("Name", _name);
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        private string _name;
        [DataMember]
        public int PeriodicityId
        {	
    		
            get { return _periodicityId; }
            set
            {
                if (_periodicityId != value)
                {
                    ChangeTracker.RecordOriginalValue("PeriodicityId", _periodicityId);
                    if (!IsDeserializing)
                    {
                        if (Periodicity != null && Periodicity.PeriodicityId != value)
                        {
                            Periodicity = null;
                        }
                    }
                    _periodicityId = value;
                    OnPropertyChanged("PeriodicityId");
                }
            }
        }
        private int _periodicityId;
        [DataMember]
        public Nullable<System.TimeSpan> CutOffTime
        {	
    		
            get { return _cutOffTime; }
            set
            {
                if (_cutOffTime != value)
                {
                    ChangeTracker.RecordOriginalValue("CutOffTime", _cutOffTime);
                    _cutOffTime = value;
                    OnPropertyChanged("CutOffTime");
                }
            }
        }
        private Nullable<System.TimeSpan> _cutOffTime;
        [DataMember]
        public int CutOffDaysPrior
        {	
    		
            get { return _cutOffDaysPrior; }
            set
            {
                if (_cutOffDaysPrior != value)
                {
                    ChangeTracker.RecordOriginalValue("CutOffDaysPrior", _cutOffDaysPrior);
                    _cutOffDaysPrior = value;
                    OnPropertyChanged("CutOffDaysPrior");
                }
            }
        }
        private int _cutOffDaysPrior;
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
        public Periodicity Periodicity
        {
            get { return _periodicity; }
            set
            {
                if (!ReferenceEquals(_periodicity, value))
                {
                    var previousValue = _periodicity;
                    _periodicity = value;
                    FixupPeriodicity(previousValue);
                    OnNavigationPropertyChanged("Periodicity");
                }
            }
        }
        private Periodicity _periodicity;
    
        [DataMember]
        public TrackableCollection<Fund> Funds
        {
            get
            {
                if (_funds == null)
                {
                    _funds = new TrackableCollection<Fund>();
                    _funds.CollectionChanged += FixupFunds;
                }
                return _funds;
            }
            set
            {
                if (!ReferenceEquals(_funds, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_funds != null)
                    {
                        _funds.CollectionChanged -= FixupFunds;
                    }
                    _funds = value;
                    if (_funds != null)
                    {
                        _funds.CollectionChanged += FixupFunds;
                    }
                    OnNavigationPropertyChanged("Funds");
                }
            }
        }
        private TrackableCollection<Fund> _funds;

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
            Periodicity = null;
            Funds.Clear();
        }

        #endregion
        #region Association Fixup
    
        private void FixupPeriodicity(Periodicity previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.DealingDateDefinitions.Contains(this))
            {
                previousValue.DealingDateDefinitions.Remove(this);
            }
    
            if (Periodicity != null)
            {
                if (!Periodicity.DealingDateDefinitions.Contains(this))
                {
                    Periodicity.DealingDateDefinitions.Add(this);
                }
    
                PeriodicityId = Periodicity.PeriodicityId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Periodicity")
                    && (ChangeTracker.OriginalValues["Periodicity"] == Periodicity))
                {
                    ChangeTracker.OriginalValues.Remove("Periodicity");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Periodicity", previousValue);
                }
                if (Periodicity != null && !Periodicity.ChangeTracker.ChangeTrackingEnabled)
                {
                    Periodicity.StartTracking();
                }
            }
        }
    
        private void FixupFunds(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Fund item in e.NewItems)
                {
                    item.DealingDateDefinition = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Funds", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Fund item in e.OldItems)
                {
                    if (ReferenceEquals(item.DealingDateDefinition, this))
                    {
                        item.DealingDateDefinition = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Funds", item);
                    }
                }
            }
        }

        #endregion
    }
}
