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
    [KnownType(typeof(ApplicationUser))]
    [KnownType(typeof(PortfolioAggregationLevel))]
    public partial class PortfolioRollDate: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
        [DataMember]
        public int PortfolioRollDateId
        {	
    		
            get { return _portfolioRollDateId; }
            set
            {
                if (_portfolioRollDateId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'PortfolioRollDateId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _portfolioRollDateId = value;
                    OnPropertyChanged("PortfolioRollDateId");
                }
            }
        }
        private int _portfolioRollDateId;
        [DataMember]
        public int PortfolioAggregationLevelId
        {	
    		
            get { return _portfolioAggregationLevelId; }
            set
            {
                if (_portfolioAggregationLevelId != value)
                {
                    ChangeTracker.RecordOriginalValue("PortfolioAggregationLevelId", _portfolioAggregationLevelId);
                    if (!IsDeserializing)
                    {
                        if (PortfolioAggregationLevel != null && PortfolioAggregationLevel.PortfolioAggregationLevelId != value)
                        {
                            PortfolioAggregationLevel = null;
                        }
                    }
                    _portfolioAggregationLevelId = value;
                    OnPropertyChanged("PortfolioAggregationLevelId");
                }
            }
        }
        private int _portfolioAggregationLevelId;
        [DataMember]
        public System.DateTime RollDate
        {	
    		
            get { return _rollDate; }
            set
            {
                if (_rollDate != value)
                {
                    ChangeTracker.RecordOriginalValue("RollDate", _rollDate);
                    _rollDate = value;
                    OnPropertyChanged("RollDate");
                }
            }
        }
        private System.DateTime _rollDate;
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
                    if (!IsDeserializing)
                    {
                        if (ApplicationUser != null && ApplicationUser.UserID != value)
                        {
                            ApplicationUser = null;
                        }
                    }
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
        public ApplicationUser ApplicationUser
        {
            get { return _applicationUser; }
            set
            {
                if (!ReferenceEquals(_applicationUser, value))
                {
                    var previousValue = _applicationUser;
                    _applicationUser = value;
                    FixupApplicationUser(previousValue);
                    OnNavigationPropertyChanged("ApplicationUser");
                }
            }
        }
        private ApplicationUser _applicationUser;
    
        [DataMember]
        public PortfolioAggregationLevel PortfolioAggregationLevel
        {
            get { return _portfolioAggregationLevel; }
            set
            {
                if (!ReferenceEquals(_portfolioAggregationLevel, value))
                {
                    var previousValue = _portfolioAggregationLevel;
                    _portfolioAggregationLevel = value;
                    FixupPortfolioAggregationLevel(previousValue);
                    OnNavigationPropertyChanged("PortfolioAggregationLevel");
                }
            }
        }
        private PortfolioAggregationLevel _portfolioAggregationLevel;

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
            ApplicationUser = null;
            PortfolioAggregationLevel = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupApplicationUser(ApplicationUser previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (ApplicationUser != null)
            {
                UpdateUserID = ApplicationUser.UserID;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("ApplicationUser")
                    && (ChangeTracker.OriginalValues["ApplicationUser"] == ApplicationUser))
                {
                    ChangeTracker.OriginalValues.Remove("ApplicationUser");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("ApplicationUser", previousValue);
                }
                if (ApplicationUser != null && !ApplicationUser.ChangeTracker.ChangeTrackingEnabled)
                {
                    ApplicationUser.StartTracking();
                }
            }
        }
    
        private void FixupPortfolioAggregationLevel(PortfolioAggregationLevel previousValue)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.PortfolioRollDates.Contains(this))
            {
                previousValue.PortfolioRollDates.Remove(this);
            }
    
            if (PortfolioAggregationLevel != null)
            {
                if (!PortfolioAggregationLevel.PortfolioRollDates.Contains(this))
                {
                    PortfolioAggregationLevel.PortfolioRollDates.Add(this);
                }
    
                PortfolioAggregationLevelId = PortfolioAggregationLevel.PortfolioAggregationLevelId;
            }
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("PortfolioAggregationLevel")
                    && (ChangeTracker.OriginalValues["PortfolioAggregationLevel"] == PortfolioAggregationLevel))
                {
                    ChangeTracker.OriginalValues.Remove("PortfolioAggregationLevel");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("PortfolioAggregationLevel", previousValue);
                }
                if (PortfolioAggregationLevel != null && !PortfolioAggregationLevel.ChangeTracker.ChangeTrackingEnabled)
                {
                    PortfolioAggregationLevel.StartTracking();
                }
            }
        }

        #endregion
    }
}
