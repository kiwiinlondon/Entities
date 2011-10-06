﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Odey.Framework.Keeley.Entities
{
    public partial class KeeleyModel : ObjectContext
    {
        public const string ConnectionString = "name=KeeleyModel";
        public const string ContainerName = "KeeleyModel";
    
        #region Constructors
    
        public KeeleyModel()
            : base(ConnectionString, ContainerName)
        {
            Initialize();
        }
    
        public KeeleyModel(string connectionString)
            : base(connectionString, ContainerName)
        {
            Initialize();
        }
    
        public KeeleyModel(EntityConnection connection)
            : base(connection, ContainerName)
        {
            Initialize();
        }
    
        private void Initialize()
        {
            // Creating proxies requires the use of the ProxyDataContractResolver and
            // may allow lazy loading which can expand the loaded graph during serialization.
            ContextOptions.ProxyCreationEnabled = false;
            ObjectMaterialized += new ObjectMaterializedEventHandler(HandleObjectMaterialized);
        }
    
        private void HandleObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            var entity = e.Entity as IObjectWithChangeTracker;
            if (entity != null)
            {
                bool changeTrackingEnabled = entity.ChangeTracker.ChangeTrackingEnabled;
                try
                {
                    entity.MarkAsUnchanged();
                }
                finally
                {
                    entity.ChangeTracker.ChangeTrackingEnabled = changeTrackingEnabled;
                }
                this.StoreReferenceKeyValues(entity);
            }
        }
    
        #endregion
    
        #region ObjectSet Properties
    
        public ObjectSet<ApplicationUser> ApplicationUsers
        {
            get { return _applicationUsers  ?? (_applicationUsers = CreateObjectSet<ApplicationUser>("ApplicationUsers")); }
        }
        private ObjectSet<ApplicationUser> _applicationUsers;
    
        public ObjectSet<Book> Books
        {
            get { return _books  ?? (_books = CreateObjectSet<Book>("Books")); }
        }
        private ObjectSet<Book> _books;
    
        public ObjectSet<Country> Countries
        {
            get { return _countries  ?? (_countries = CreateObjectSet<Country>("Countries")); }
        }
        private ObjectSet<Country> _countries;
    
        public ObjectSet<Fund> Funds
        {
            get { return _funds  ?? (_funds = CreateObjectSet<Fund>("Funds")); }
        }
        private ObjectSet<Fund> _funds;
    
        public ObjectSet<Instrument> Instruments
        {
            get { return _instruments  ?? (_instruments = CreateObjectSet<Instrument>("Instruments")); }
        }
        private ObjectSet<Instrument> _instruments;
    
        public ObjectSet<InstrumentClass> InstrumentClasses
        {
            get { return _instrumentClasses  ?? (_instrumentClasses = CreateObjectSet<InstrumentClass>("InstrumentClasses")); }
        }
        private ObjectSet<InstrumentClass> _instrumentClasses;
    
        public ObjectSet<Market> Markets
        {
            get { return _markets  ?? (_markets = CreateObjectSet<Market>("Markets")); }
        }
        private ObjectSet<Market> _markets;
    
        public ObjectSet<Region> Regions
        {
            get { return _regions  ?? (_regions = CreateObjectSet<Region>("Regions")); }
        }
        private ObjectSet<Region> _regions;
    
        public ObjectSet<IdentifierType> IdentifierTypes
        {
            get { return _identifierTypes  ?? (_identifierTypes = CreateObjectSet<IdentifierType>("IdentifierTypes")); }
        }
        private ObjectSet<IdentifierType> _identifierTypes;
    
        public ObjectSet<InstrumentRelationship> InstrumentRelationships
        {
            get { return _instrumentRelationships  ?? (_instrumentRelationships = CreateObjectSet<InstrumentRelationship>("InstrumentRelationships")); }
        }
        private ObjectSet<InstrumentRelationship> _instrumentRelationships;
    
        public ObjectSet<Account> Accounts
        {
            get { return _accounts  ?? (_accounts = CreateObjectSet<Account>("Accounts")); }
        }
        private ObjectSet<Account> _accounts;
    
        public ObjectSet<CapitalEvent> CapitalEvents
        {
            get { return _capitalEvents  ?? (_capitalEvents = CreateObjectSet<CapitalEvent>("CapitalEvents")); }
        }
        private ObjectSet<CapitalEvent> _capitalEvents;
    
        public ObjectSet<Custodian> Custodians
        {
            get { return _custodians  ?? (_custodians = CreateObjectSet<Custodian>("Custodians")); }
        }
        private ObjectSet<Custodian> _custodians;
    
        public ObjectSet<Event> Events
        {
            get { return _events  ?? (_events = CreateObjectSet<Event>("Events")); }
        }
        private ObjectSet<Event> _events;
    
        public ObjectSet<EventType> EventTypes
        {
            get { return _eventTypes  ?? (_eventTypes = CreateObjectSet<EventType>("EventTypes")); }
        }
        private ObjectSet<EventType> _eventTypes;
    
        public ObjectSet<InstrumentEvent> InstrumentEvents
        {
            get { return _instrumentEvents  ?? (_instrumentEvents = CreateObjectSet<InstrumentEvent>("InstrumentEvents")); }
        }
        private ObjectSet<InstrumentEvent> _instrumentEvents;
    
        public ObjectSet<InstrumentEventType> InstrumentEventTypes
        {
            get { return _instrumentEventTypes  ?? (_instrumentEventTypes = CreateObjectSet<InstrumentEventType>("InstrumentEventTypes")); }
        }
        private ObjectSet<InstrumentEventType> _instrumentEventTypes;
    
        public ObjectSet<Currency> Currencies
        {
            get { return _currencies  ?? (_currencies = CreateObjectSet<Currency>("Currencies")); }
        }
        private ObjectSet<Currency> _currencies;
    
        public ObjectSet<Counterparty> Counterparties
        {
            get { return _counterparties  ?? (_counterparties = CreateObjectSet<Counterparty>("Counterparties")); }
        }
        private ObjectSet<Counterparty> _counterparties;
    
        public ObjectSet<LegalEntity> LegalEntities
        {
            get { return _legalEntities  ?? (_legalEntities = CreateObjectSet<LegalEntity>("LegalEntities")); }
        }
        private ObjectSet<LegalEntity> _legalEntities;
    
        public ObjectSet<BuySellReason> BuySellReasons
        {
            get { return _buySellReasons  ?? (_buySellReasons = CreateObjectSet<BuySellReason>("BuySellReasons")); }
        }
        private ObjectSet<BuySellReason> _buySellReasons;
    
        public ObjectSet<TradeEvent> TradeEvents
        {
            get { return _tradeEvents  ?? (_tradeEvents = CreateObjectSet<TradeEvent>("TradeEvents")); }
        }
        private ObjectSet<TradeEvent> _tradeEvents;
    
        public ObjectSet<MatchedStatus> MatchedStatuses
        {
            get { return _matchedStatuses  ?? (_matchedStatuses = CreateObjectSet<MatchedStatus>("MatchedStatuses")); }
        }
        private ObjectSet<MatchedStatus> _matchedStatuses;
    
        public ObjectSet<FXTradeEvent> FXTradeEvents
        {
            get { return _fXTradeEvents  ?? (_fXTradeEvents = CreateObjectSet<FXTradeEvent>("FXTradeEvents")); }
        }
        private ObjectSet<FXTradeEvent> _fXTradeEvents;
    
        public ObjectSet<ChargeType> ChargeTypes
        {
            get { return _chargeTypes  ?? (_chargeTypes = CreateObjectSet<ChargeType>("ChargeTypes")); }
        }
        private ObjectSet<ChargeType> _chargeTypes;
    
        public ObjectSet<PortfolioAggregationLevel> PortfolioAggregationLevels
        {
            get { return _portfolioAggregationLevels  ?? (_portfolioAggregationLevels = CreateObjectSet<PortfolioAggregationLevel>("PortfolioAggregationLevels")); }
        }
        private ObjectSet<PortfolioAggregationLevel> _portfolioAggregationLevels;
    
        public ObjectSet<InternalAllocation> InternalAllocations
        {
            get { return _internalAllocations  ?? (_internalAllocations = CreateObjectSet<InternalAllocation>("InternalAllocations")); }
        }
        private ObjectSet<InternalAllocation> _internalAllocations;
    
        public ObjectSet<InternalAccountingEvent> InternalAccountingEvents
        {
            get { return _internalAccountingEvents  ?? (_internalAccountingEvents = CreateObjectSet<InternalAccountingEvent>("InternalAccountingEvents")); }
        }
        private ObjectSet<InternalAccountingEvent> _internalAccountingEvents;
    
        public ObjectSet<InternalAccountingEventType> InternalAccountingEventTypes
        {
            get { return _internalAccountingEventTypes  ?? (_internalAccountingEventTypes = CreateObjectSet<InternalAccountingEventType>("InternalAccountingEventTypes")); }
        }
        private ObjectSet<InternalAccountingEventType> _internalAccountingEventTypes;
    
        public ObjectSet<InstrumentClassHierarchy> InstrumentClassHierarchies
        {
            get { return _instrumentClassHierarchies  ?? (_instrumentClassHierarchies = CreateObjectSet<InstrumentClassHierarchy>("InstrumentClassHierarchies")); }
        }
        private ObjectSet<InstrumentClassHierarchy> _instrumentClassHierarchies;
    
        public ObjectSet<InstrumentClassRelationship> InstrumentClassRelationships
        {
            get { return _instrumentClassRelationships  ?? (_instrumentClassRelationships = CreateObjectSet<InstrumentClassRelationship>("InstrumentClassRelationships")); }
        }
        private ObjectSet<InstrumentClassRelationship> _instrumentClassRelationships;
    
        public ObjectSet<EntityProperty> EntityProperties
        {
            get { return _entityProperties  ?? (_entityProperties = CreateObjectSet<EntityProperty>("EntityProperties")); }
        }
        private ObjectSet<EntityProperty> _entityProperties;
    
        public ObjectSet<Extract> Extracts
        {
            get { return _extracts  ?? (_extracts = CreateObjectSet<Extract>("Extracts")); }
        }
        private ObjectSet<Extract> _extracts;
    
        public ObjectSet<ExtractEntity> ExtractEntities
        {
            get { return _extractEntities  ?? (_extractEntities = CreateObjectSet<ExtractEntity>("ExtractEntities")); }
        }
        private ObjectSet<ExtractEntity> _extractEntities;
    
        public ObjectSet<ExtractInputConfiguration> ExtractInputConfigurations
        {
            get { return _extractInputConfigurations  ?? (_extractInputConfigurations = CreateObjectSet<ExtractInputConfiguration>("ExtractInputConfigurations")); }
        }
        private ObjectSet<ExtractInputConfiguration> _extractInputConfigurations;
    
        public ObjectSet<ExtractRun> ExtractRuns
        {
            get { return _extractRuns  ?? (_extractRuns = CreateObjectSet<ExtractRun>("ExtractRuns")); }
        }
        private ObjectSet<ExtractRun> _extractRuns;
    
        public ObjectSet<ExtractType> ExtractTypes
        {
            get { return _extractTypes  ?? (_extractTypes = CreateObjectSet<ExtractType>("ExtractTypes")); }
        }
        private ObjectSet<ExtractType> _extractTypes;
    
        public ObjectSet<PortfolioEventType> PortfolioEventTypes
        {
            get { return _portfolioEventTypes  ?? (_portfolioEventTypes = CreateObjectSet<PortfolioEventType>("PortfolioEventTypes")); }
        }
        private ObjectSet<PortfolioEventType> _portfolioEventTypes;
    
        public ObjectSet<ExtractEntityPropertyValue> ExtractEntityPropertyValues
        {
            get { return _extractEntityPropertyValues  ?? (_extractEntityPropertyValues = CreateObjectSet<ExtractEntityPropertyValue>("ExtractEntityPropertyValues")); }
        }
        private ObjectSet<ExtractEntityPropertyValue> _extractEntityPropertyValues;
    
        public ObjectSet<ExtractOutputType> ExtractOutputTypes
        {
            get { return _extractOutputTypes  ?? (_extractOutputTypes = CreateObjectSet<ExtractOutputType>("ExtractOutputTypes")); }
        }
        private ObjectSet<ExtractOutputType> _extractOutputTypes;
    
        public ObjectSet<ExtractConfiguration> ExtractConfigurations
        {
            get { return _extractConfigurations  ?? (_extractConfigurations = CreateObjectSet<ExtractConfiguration>("ExtractConfigurations")); }
        }
        private ObjectSet<ExtractConfiguration> _extractConfigurations;
    
        public ObjectSet<PortfolioEvent> PortfolioEvents
        {
            get { return _portfolioEvents  ?? (_portfolioEvents = CreateObjectSet<PortfolioEvent>("PortfolioEvents")); }
        }
        private ObjectSet<PortfolioEvent> _portfolioEvents;
    
        public ObjectSet<PortfolioSettlementDate> PortfolioSettlementDates
        {
            get { return _portfolioSettlementDates  ?? (_portfolioSettlementDates = CreateObjectSet<PortfolioSettlementDate>("PortfolioSettlementDates")); }
        }
        private ObjectSet<PortfolioSettlementDate> _portfolioSettlementDates;
    
        public ObjectSet<Position> Positions
        {
            get { return _positions  ?? (_positions = CreateObjectSet<Position>("Positions")); }
        }
        private ObjectSet<Position> _positions;
    
        public ObjectSet<Portfolio> Portfolios
        {
            get { return _portfolios  ?? (_portfolios = CreateObjectSet<Portfolio>("Portfolios")); }
        }
        private ObjectSet<Portfolio> _portfolios;
    
        public ObjectSet<EntityRankingScheme> EntityRankingSchemes
        {
            get { return _entityRankingSchemes  ?? (_entityRankingSchemes = CreateObjectSet<EntityRankingScheme>("EntityRankingSchemes")); }
        }
        private ObjectSet<EntityRankingScheme> _entityRankingSchemes;
    
        public ObjectSet<EntityRankingSchemeItem> EntityRankingSchemeItems
        {
            get { return _entityRankingSchemeItems  ?? (_entityRankingSchemeItems = CreateObjectSet<EntityRankingSchemeItem>("EntityRankingSchemeItems")); }
        }
        private ObjectSet<EntityRankingSchemeItem> _entityRankingSchemeItems;
    
        public ObjectSet<FXRate> FXRates
        {
            get { return _fXRates  ?? (_fXRates = CreateObjectSet<FXRate>("FXRates")); }
        }
        private ObjectSet<FXRate> _fXRates;
    
        public ObjectSet<RawFXRate> RawFXRates
        {
            get { return _rawFXRates  ?? (_rawFXRates = CreateObjectSet<RawFXRate>("RawFXRates")); }
        }
        private ObjectSet<RawFXRate> _rawFXRates;
    
        public ObjectSet<EntityRankingSchemeOrder> EntityRankingSchemeOrders
        {
            get { return _entityRankingSchemeOrders  ?? (_entityRankingSchemeOrders = CreateObjectSet<EntityRankingSchemeOrder>("EntityRankingSchemeOrders")); }
        }
        private ObjectSet<EntityRankingSchemeOrder> _entityRankingSchemeOrders;
    
        public ObjectSet<EventInstrumentMap> EventInstrumentMaps
        {
            get { return _eventInstrumentMaps  ?? (_eventInstrumentMaps = CreateObjectSet<EventInstrumentMap>("EventInstrumentMaps")); }
        }
        private ObjectSet<EventInstrumentMap> _eventInstrumentMaps;
    
        public ObjectSet<InstrumentMarket> InstrumentMarkets
        {
            get { return _instrumentMarkets  ?? (_instrumentMarkets = CreateObjectSet<InstrumentMarket>("InstrumentMarkets")); }
        }
        private ObjectSet<InstrumentMarket> _instrumentMarkets;
    
        public ObjectSet<Charge> Charges
        {
            get { return _charges  ?? (_charges = CreateObjectSet<Charge>("Charges")); }
        }
        private ObjectSet<Charge> _charges;
    
        public ObjectSet<PortfolioRollDate> PortfolioRollDates
        {
            get { return _portfolioRollDates  ?? (_portfolioRollDates = CreateObjectSet<PortfolioRollDate>("PortfolioRollDates")); }
        }
        private ObjectSet<PortfolioRollDate> _portfolioRollDates;
    
        public ObjectSet<Price> Prices
        {
            get { return _prices  ?? (_prices = CreateObjectSet<Price>("Prices")); }
        }
        private ObjectSet<Price> _prices;
    
        public ObjectSet<RawPrice> RawPrices
        {
            get { return _rawPrices  ?? (_rawPrices = CreateObjectSet<RawPrice>("RawPrices")); }
        }
        private ObjectSet<RawPrice> _rawPrices;
    
        public ObjectSet<ExtractOutputConfiguration> ExtractOutputConfigurations
        {
            get { return _extractOutputConfigurations  ?? (_extractOutputConfigurations = CreateObjectSet<ExtractOutputConfiguration>("ExtractOutputConfigurations")); }
        }
        private ObjectSet<ExtractOutputConfiguration> _extractOutputConfigurations;
    
        public ObjectSet<Industry> Industries
        {
            get { return _industries  ?? (_industries = CreateObjectSet<Industry>("Industries")); }
        }
        private ObjectSet<Industry> _industries;
    
        public ObjectSet<Issuer> Issuers
        {
            get { return _issuers  ?? (_issuers = CreateObjectSet<Issuer>("Issuers")); }
        }
        private ObjectSet<Issuer> _issuers;
    
        public ObjectSet<IssuerIndustry> IssuerIndustries
        {
            get { return _issuerIndustries  ?? (_issuerIndustries = CreateObjectSet<IssuerIndustry>("IssuerIndustries")); }
        }
        private ObjectSet<IssuerIndustry> _issuerIndustries;
    
        public ObjectSet<Analytic> Analytics
        {
            get { return _analytics  ?? (_analytics = CreateObjectSet<Analytic>("Analytics")); }
        }
        private ObjectSet<Analytic> _analytics;
    
        public ObjectSet<RawAnalytic> RawAnalytics
        {
            get { return _rawAnalytics  ?? (_rawAnalytics = CreateObjectSet<RawAnalytic>("RawAnalytics")); }
        }
        private ObjectSet<RawAnalytic> _rawAnalytics;

        #endregion
        #region Function Imports
        public virtual ObjectResult<PortfolioEvent> PortfolioEventGetPrevious(Nullable<int> positionID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> inputDate, Nullable<int> orderingResolution, Nullable<int> portfolioAggregationLevelId, Nullable<int> portfolioEventId)
        {
    
            ObjectParameter positionIDParameter;
    
            if (positionID.HasValue)
            {
                positionIDParameter = new ObjectParameter("PositionID", positionID);
            }
            else
            {
                positionIDParameter = new ObjectParameter("PositionID", typeof(int));
            }
    
            ObjectParameter referenceDateParameter;
    
            if (referenceDate.HasValue)
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", referenceDate);
            }
            else
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", typeof(System.DateTime));
            }
    
            ObjectParameter inputDateParameter;
    
            if (inputDate.HasValue)
            {
                inputDateParameter = new ObjectParameter("InputDate", inputDate);
            }
            else
            {
                inputDateParameter = new ObjectParameter("InputDate", typeof(System.DateTime));
            }
    
            ObjectParameter orderingResolutionParameter;
    
            if (orderingResolution.HasValue)
            {
                orderingResolutionParameter = new ObjectParameter("OrderingResolution", orderingResolution);
            }
            else
            {
                orderingResolutionParameter = new ObjectParameter("OrderingResolution", typeof(int));
            }
    
            ObjectParameter portfolioAggregationLevelIdParameter;
    
            if (portfolioAggregationLevelId.HasValue)
            {
                portfolioAggregationLevelIdParameter = new ObjectParameter("PortfolioAggregationLevelId", portfolioAggregationLevelId);
            }
            else
            {
                portfolioAggregationLevelIdParameter = new ObjectParameter("PortfolioAggregationLevelId", typeof(int));
            }
    
            ObjectParameter portfolioEventIdParameter;
    
            if (portfolioEventId.HasValue)
            {
                portfolioEventIdParameter = new ObjectParameter("PortfolioEventId", portfolioEventId);
            }
            else
            {
                portfolioEventIdParameter = new ObjectParameter("PortfolioEventId", typeof(int));
            }
            return base.ExecuteFunction<PortfolioEvent>("PortfolioEventGetPrevious", positionIDParameter, referenceDateParameter, inputDateParameter, orderingResolutionParameter, portfolioAggregationLevelIdParameter, portfolioEventIdParameter);
        }
        public virtual ObjectResult<Nullable<System.DateTime>> RollPortfolio(Nullable<int> updateUserId)
        {
    
            ObjectParameter updateUserIdParameter;
    
            if (updateUserId.HasValue)
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", updateUserId);
            }
            else
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", typeof(int));
            }
            return base.ExecuteFunction<Nullable<System.DateTime>>("RollPortfolio", updateUserIdParameter);
        }
        public virtual ObjectResult<Nullable<System.DateTime>> RollPortfolioSettlementDate(Nullable<int> updateUserId)
        {
    
            ObjectParameter updateUserIdParameter;
    
            if (updateUserId.HasValue)
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", updateUserId);
            }
            else
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", typeof(int));
            }
            return base.ExecuteFunction<Nullable<System.DateTime>>("RollPortfolioSettlementDate", updateUserIdParameter);
        }
        public virtual ObjectResult<Position> PositionGetForFundIdExcludingCurrencies(Nullable<int> fundId)
        {
    
            ObjectParameter fundIdParameter;
    
            if (fundId.HasValue)
            {
                fundIdParameter = new ObjectParameter("fundId", fundId);
            }
            else
            {
                fundIdParameter = new ObjectParameter("fundId", typeof(int));
            }
            return base.ExecuteFunction<Position>("PositionGetForFundIdExcludingCurrencies", fundIdParameter);
        }
        public virtual ObjectResult<Nullable<int>> GetPositionIdsWherePortfolioEventBreak()
        {
            return base.ExecuteFunction<Nullable<int>>("GetPositionIdsWherePortfolioEventBreak");
        }
        public virtual ObjectResult<RawFXRate> RawFXRate_GetLatest(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore)
        {
    
            ObjectParameter currencyIDParameter;
    
            if (currencyID.HasValue)
            {
                currencyIDParameter = new ObjectParameter("CurrencyID", currencyID);
            }
            else
            {
                currencyIDParameter = new ObjectParameter("CurrencyID", typeof(int));
            }
    
            ObjectParameter referenceDateParameter;
    
            if (referenceDate.HasValue)
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", referenceDate);
            }
            else
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", typeof(System.DateTime));
            }
    
            ObjectParameter entityRankingSchemeIdParameter;
    
            if (entityRankingSchemeId.HasValue)
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId);
            }
            else
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", typeof(int));
            }
    
            ObjectParameter rawFXRateIdToIgnoreParameter;
    
            if (rawFXRateIdToIgnore.HasValue)
            {
                rawFXRateIdToIgnoreParameter = new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore);
            }
            else
            {
                rawFXRateIdToIgnoreParameter = new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
            }
            return base.ExecuteFunction<RawFXRate>("RawFXRate_GetLatest", currencyIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
        public virtual ObjectResult<RawPrice> RawPrices_GetLatest(Nullable<int> instrumentMarketID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawPriceIdToIgnore)
        {
    
            ObjectParameter instrumentMarketIDParameter;
    
            if (instrumentMarketID.HasValue)
            {
                instrumentMarketIDParameter = new ObjectParameter("InstrumentMarketID", instrumentMarketID);
            }
            else
            {
                instrumentMarketIDParameter = new ObjectParameter("InstrumentMarketID", typeof(int));
            }
    
            ObjectParameter referenceDateParameter;
    
            if (referenceDate.HasValue)
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", referenceDate);
            }
            else
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", typeof(System.DateTime));
            }
    
            ObjectParameter entityRankingSchemeIdParameter;
    
            if (entityRankingSchemeId.HasValue)
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId);
            }
            else
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", typeof(int));
            }
    
            ObjectParameter rawPriceIdToIgnoreParameter;
    
            if (rawPriceIdToIgnore.HasValue)
            {
                rawPriceIdToIgnoreParameter = new ObjectParameter("RawPriceIdToIgnore", rawPriceIdToIgnore);
            }
            else
            {
                rawPriceIdToIgnoreParameter = new ObjectParameter("RawPriceIdToIgnore", typeof(int));
            }
            return base.ExecuteFunction<RawPrice>("RawPrices_GetLatest", instrumentMarketIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawPriceIdToIgnoreParameter);
        }
        public virtual ObjectResult<Nullable<System.DateTime>> FXRates_Roll(Nullable<int> updateUserId)
        {
    
            ObjectParameter updateUserIdParameter;
    
            if (updateUserId.HasValue)
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", updateUserId);
            }
            else
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", typeof(int));
            }
            return base.ExecuteFunction<Nullable<System.DateTime>>("FXRates_Roll", updateUserIdParameter);
        }
        public virtual ObjectResult<Nullable<System.DateTime>> Prices_Roll(Nullable<int> updateUserId)
        {
    
            ObjectParameter updateUserIdParameter;
    
            if (updateUserId.HasValue)
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", updateUserId);
            }
            else
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", typeof(int));
            }
            return base.ExecuteFunction<Nullable<System.DateTime>>("Prices_Roll", updateUserIdParameter);
        }
        public virtual ObjectResult<RawFXRate> RawFXRate_GetlatestForForward(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> forwardDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore)
        {
    
            ObjectParameter currencyIDParameter;
    
            if (currencyID.HasValue)
            {
                currencyIDParameter = new ObjectParameter("CurrencyID", currencyID);
            }
            else
            {
                currencyIDParameter = new ObjectParameter("CurrencyID", typeof(int));
            }
    
            ObjectParameter referenceDateParameter;
    
            if (referenceDate.HasValue)
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", referenceDate);
            }
            else
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", typeof(System.DateTime));
            }
    
            ObjectParameter forwardDateParameter;
    
            if (forwardDate.HasValue)
            {
                forwardDateParameter = new ObjectParameter("ForwardDate", forwardDate);
            }
            else
            {
                forwardDateParameter = new ObjectParameter("ForwardDate", typeof(System.DateTime));
            }
    
            ObjectParameter entityRankingSchemeIdParameter;
    
            if (entityRankingSchemeId.HasValue)
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId);
            }
            else
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", typeof(int));
            }
    
            ObjectParameter rawFXRateIdToIgnoreParameter;
    
            if (rawFXRateIdToIgnore.HasValue)
            {
                rawFXRateIdToIgnoreParameter = new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore);
            }
            else
            {
                rawFXRateIdToIgnoreParameter = new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
            }
            return base.ExecuteFunction<RawFXRate>("RawFXRate_GetlatestForForward", currencyIDParameter, referenceDateParameter, forwardDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
        public virtual ObjectResult<RawAnalytic> RawAnalytic_GetLatest(Nullable<int> instrumentMarketID, Nullable<int> analyticTypeID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawAnalyticIdToIgnore)
        {
    
            ObjectParameter instrumentMarketIDParameter;
    
            if (instrumentMarketID.HasValue)
            {
                instrumentMarketIDParameter = new ObjectParameter("InstrumentMarketID", instrumentMarketID);
            }
            else
            {
                instrumentMarketIDParameter = new ObjectParameter("InstrumentMarketID", typeof(int));
            }
    
            ObjectParameter analyticTypeIDParameter;
    
            if (analyticTypeID.HasValue)
            {
                analyticTypeIDParameter = new ObjectParameter("AnalyticTypeID", analyticTypeID);
            }
            else
            {
                analyticTypeIDParameter = new ObjectParameter("AnalyticTypeID", typeof(int));
            }
    
            ObjectParameter referenceDateParameter;
    
            if (referenceDate.HasValue)
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", referenceDate);
            }
            else
            {
                referenceDateParameter = new ObjectParameter("ReferenceDate", typeof(System.DateTime));
            }
    
            ObjectParameter entityRankingSchemeIdParameter;
    
            if (entityRankingSchemeId.HasValue)
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId);
            }
            else
            {
                entityRankingSchemeIdParameter = new ObjectParameter("EntityRankingSchemeId", typeof(int));
            }
    
            ObjectParameter rawAnalyticIdToIgnoreParameter;
    
            if (rawAnalyticIdToIgnore.HasValue)
            {
                rawAnalyticIdToIgnoreParameter = new ObjectParameter("RawAnalyticIdToIgnore", rawAnalyticIdToIgnore);
            }
            else
            {
                rawAnalyticIdToIgnoreParameter = new ObjectParameter("RawAnalyticIdToIgnore", typeof(int));
            }
            return base.ExecuteFunction<RawAnalytic>("RawAnalytic_GetLatest", instrumentMarketIDParameter, analyticTypeIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawAnalyticIdToIgnoreParameter);
        }
        public virtual ObjectResult<Nullable<System.DateTime>> Analytic_Roll(Nullable<int> updateUserId)
        {
    
            ObjectParameter updateUserIdParameter;
    
            if (updateUserId.HasValue)
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", updateUserId);
            }
            else
            {
                updateUserIdParameter = new ObjectParameter("UpdateUserId", typeof(int));
            }
            return base.ExecuteFunction<Nullable<System.DateTime>>("Analytic_Roll", updateUserIdParameter);
        }

        #endregion
    }
}
