﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Odey.Framework.Keeley.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class KeeleyModel : DbContext
    {
        public KeeleyModel()
            : base("name=KeeleyModel")
        {
            this.Configuration.LazyLoadingEnabled = false;
    		this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<InstrumentClass> InstrumentClasses { get; set; }
        public DbSet<Market> Markets { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<IdentifierType> IdentifierTypes { get; set; }
        public DbSet<InstrumentRelationship> InstrumentRelationships { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CapitalEvent> CapitalEvents { get; set; }
        public DbSet<Custodian> Custodians { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }
        public DbSet<InstrumentEvent> InstrumentEvents { get; set; }
        public DbSet<InstrumentEventType> InstrumentEventTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<BuySellReason> BuySellReasons { get; set; }
        public DbSet<TradeEvent> TradeEvents { get; set; }
        public DbSet<MatchedStatus> MatchedStatuses { get; set; }
        public DbSet<FXTradeEvent> FXTradeEvents { get; set; }
        public DbSet<ChargeType> ChargeTypes { get; set; }
        public DbSet<PortfolioAggregationLevel> PortfolioAggregationLevels { get; set; }
        public DbSet<InternalAllocation> InternalAllocations { get; set; }
        public DbSet<InstrumentClassHierarchy> InstrumentClassHierarchies { get; set; }
        public DbSet<InstrumentClassRelationship> InstrumentClassRelationships { get; set; }
        public DbSet<EntityProperty> EntityProperties { get; set; }
        public DbSet<Extract> Extracts { get; set; }
        public DbSet<ExtractEntity> ExtractEntities { get; set; }
        public DbSet<ExtractInputConfiguration> ExtractInputConfigurations { get; set; }
        public DbSet<ExtractRun> ExtractRuns { get; set; }
        public DbSet<ExtractType> ExtractTypes { get; set; }
        public DbSet<PortfolioEventType> PortfolioEventTypes { get; set; }
        public DbSet<ExtractEntityPropertyValue> ExtractEntityPropertyValues { get; set; }
        public DbSet<ExtractOutputType> ExtractOutputTypes { get; set; }
        public DbSet<ExtractConfiguration> ExtractConfigurations { get; set; }
        public DbSet<PortfolioEvent> PortfolioEvents { get; set; }
        public DbSet<PortfolioSettlementDate> PortfolioSettlementDates { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<EntityRankingScheme> EntityRankingSchemes { get; set; }
        public DbSet<EntityRankingSchemeItem> EntityRankingSchemeItems { get; set; }
        public DbSet<FXRate> FXRates { get; set; }
        public DbSet<RawFXRate> RawFXRates { get; set; }
        public DbSet<EntityRankingSchemeOrder> EntityRankingSchemeOrders { get; set; }
        public DbSet<InstrumentMarket> InstrumentMarkets { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<PortfolioRollDate> PortfolioRollDates { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<RawPrice> RawPrices { get; set; }
        public DbSet<ExtractOutputConfiguration> ExtractOutputConfigurations { get; set; }
        public DbSet<Issuer> Issuers { get; set; }
        public DbSet<Analytic> Analytics { get; set; }
        public DbSet<RawAnalytic> RawAnalytics { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<IssuerIndustry> IssuerIndustries { get; set; }
        public DbSet<CountryHoliday> CountryHolidays { get; set; }
        public DbSet<FundPerformance> FundPerformances { get; set; }
        public DbSet<CollectiveInvestmentScheme> CollectiveInvestmentSchemes { get; set; }
        public DbSet<Periodicity> Periodicities { get; set; }
        public DbSet<PeriodicityInterval> PeriodicityIntervals { get; set; }
        public DbSet<ExtractGroup> ExtractGroups { get; set; }
        public DbSet<ExtractGroupItem> ExtractGroupItems { get; set; }
        public DbSet<FMTradeBridgeLastProcessed> FMTradeBridgeLastProcesseds { get; set; }
        public DbSet<IdentifierMapping> IdentifierMappings { get; set; }
        public DbSet<EntityPropertyOverride> EntityPropertyOverrides { get; set; }
        public DbSet<FundWebsiteCacheTime> FundWebsiteCacheTimes { get; set; }
        public DbSet<DealingDateDefinition> DealingDateDefinitions { get; set; }
        public DbSet<ChargeSchedule> ChargeSchedules { get; set; }
        public DbSet<AccountMapping> AccountMappings { get; set; }
        public DbSet<LegalEntityChargeSchedule> LegalEntityChargeSchedules { get; set; }
        public DbSet<ForwardFX> ForwardFXes { get; set; }
        public DbSet<EventIdToRepull> EventIdToRepulls { get; set; }
        public DbSet<FileCollected> FileCollecteds { get; set; }
        public DbSet<FileToBeCollected> FileToBeCollecteds { get; set; }
        public DbSet<CacheInvalidation> CacheInvalidations { get; set; }
        public DbSet<FundNetAssetValue> FundNetAssetValues { get; set; }
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<RestrictedList> RestrictedLists { get; set; }
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Exposure> Exposures { get; set; }
        public DbSet<IndexConstituent> IndexConstituents { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientAccount> ClientAccounts { get; set; }
        public DbSet<ClientTrade> ClientTrades { get; set; }
        public DbSet<ClientPortfolio> ClientPortfolios { get; set; }
        public DbSet<InterestRateReturn> InterestRateReturns { get; set; }
        public DbSet<FailedTrade> FailedTrades { get; set; }
        public DbSet<Beta> Beta { get; set; }
        public DbSet<FileToBeCollectedGroup> FileToBeCollectedGroup { get; set; }
        public DbSet<Index> Indices { get; set; }
        public DbSet<ClientPortfolioBridge> ClientPortfolioBridges { get; set; }
        public DbSet<HealthCheck> HealthChecks { get; set; }
        public DbSet<FundCapitalChange> FundCapitalChanges { get; set; }
        public DbSet<OfficialNetAssetValue> OfficialNetAssetValues { get; set; }
        public DbSet<ClientSubAccountAdministratorMapping> ClientSubAccountAdministratorMappings { get; set; }
        public DbSet<FocusList> FocusLists { get; set; }
        public DbSet<PADealingAccount> PADealingAccounts { get; set; }
        public DbSet<PADealingBalance> PADealingBalances { get; set; }
        public DbSet<PADealing> PADealings { get; set; }
        public DbSet<FMPortfolio> FMPortfolios { get; set; }
        public DbSet<TransferEvent> TransferEvents { get; set; }
        public DbSet<PADealingBroker> PADealingBrokers { get; set; }
        public DbSet<ManagerPriceTarget> ManagerPriceTargets { get; set; }
        public DbSet<ManagerPriceTargetIssuer> ManagerPriceTargetIssuers { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<ClosedPosition> ClosedPositions { get; set; }
        public DbSet<DerivedAssetClass> DerivedAssetClasses { get; set; }
        public DbSet<SecurityGroup> SecurityGroups { get; set; }
        public DbSet<SecurityGroupFunctionPoint> SecurityGroupFunctionPoints { get; set; }
        public DbSet<AdministratorPortfolio> AdministratorPortfolios { get; set; }
        public DbSet<FundCountryHoliday> FundCountryHolidays { get; set; }
        public DbSet<CorporateAction> CorporateActions { get; set; }
        public DbSet<CorporateActionType> CorporateActionTypes { get; set; }
        public DbSet<Attribution> Attributions { get; set; }
        public DbSet<AnalystIdea> AnalystIdeas { get; set; }
        public DbSet<RiskAnalytic> RiskAnalytics { get; set; }
    
        public virtual ObjectResult<PortfolioEvent> PortfolioEventGetPrevious(Nullable<int> positionID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> inputDate, Nullable<int> orderingResolution, Nullable<int> portfolioAggregationLevelId, Nullable<int> portfolioEventId)
        {
            var positionIDParameter = positionID.HasValue ?
                new ObjectParameter("PositionID", positionID) :
                new ObjectParameter("PositionID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var inputDateParameter = inputDate.HasValue ?
                new ObjectParameter("InputDate", inputDate) :
                new ObjectParameter("InputDate", typeof(System.DateTime));
    
            var orderingResolutionParameter = orderingResolution.HasValue ?
                new ObjectParameter("OrderingResolution", orderingResolution) :
                new ObjectParameter("OrderingResolution", typeof(int));
    
            var portfolioAggregationLevelIdParameter = portfolioAggregationLevelId.HasValue ?
                new ObjectParameter("PortfolioAggregationLevelId", portfolioAggregationLevelId) :
                new ObjectParameter("PortfolioAggregationLevelId", typeof(int));
    
            var portfolioEventIdParameter = portfolioEventId.HasValue ?
                new ObjectParameter("PortfolioEventId", portfolioEventId) :
                new ObjectParameter("PortfolioEventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PortfolioEvent>("PortfolioEventGetPrevious", positionIDParameter, referenceDateParameter, inputDateParameter, orderingResolutionParameter, portfolioAggregationLevelIdParameter, portfolioEventIdParameter);
        }
    
        public virtual ObjectResult<PortfolioEvent> PortfolioEventGetPrevious(Nullable<int> positionID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> inputDate, Nullable<int> orderingResolution, Nullable<int> portfolioAggregationLevelId, Nullable<int> portfolioEventId, MergeOption mergeOption)
        {
            var positionIDParameter = positionID.HasValue ?
                new ObjectParameter("PositionID", positionID) :
                new ObjectParameter("PositionID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var inputDateParameter = inputDate.HasValue ?
                new ObjectParameter("InputDate", inputDate) :
                new ObjectParameter("InputDate", typeof(System.DateTime));
    
            var orderingResolutionParameter = orderingResolution.HasValue ?
                new ObjectParameter("OrderingResolution", orderingResolution) :
                new ObjectParameter("OrderingResolution", typeof(int));
    
            var portfolioAggregationLevelIdParameter = portfolioAggregationLevelId.HasValue ?
                new ObjectParameter("PortfolioAggregationLevelId", portfolioAggregationLevelId) :
                new ObjectParameter("PortfolioAggregationLevelId", typeof(int));
    
            var portfolioEventIdParameter = portfolioEventId.HasValue ?
                new ObjectParameter("PortfolioEventId", portfolioEventId) :
                new ObjectParameter("PortfolioEventId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PortfolioEvent>("PortfolioEventGetPrevious", mergeOption, positionIDParameter, referenceDateParameter, inputDateParameter, orderingResolutionParameter, portfolioAggregationLevelIdParameter, portfolioEventIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> RollPortfolio(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("RollPortfolio", updateUserIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> RollPortfolioSettlementDate(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("RollPortfolioSettlementDate", updateUserIdParameter);
        }
    
        public virtual ObjectResult<Position> PositionGetForFundIdExcludingCurrencies(Nullable<int> fundId)
        {
            var fundIdParameter = fundId.HasValue ?
                new ObjectParameter("fundId", fundId) :
                new ObjectParameter("fundId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Position>("PositionGetForFundIdExcludingCurrencies", fundIdParameter);
        }
    
        public virtual ObjectResult<Position> PositionGetForFundIdExcludingCurrencies(Nullable<int> fundId, MergeOption mergeOption)
        {
            var fundIdParameter = fundId.HasValue ?
                new ObjectParameter("fundId", fundId) :
                new ObjectParameter("fundId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Position>("PositionGetForFundIdExcludingCurrencies", mergeOption, fundIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GetPositionIdsWherePortfolioEventBreak()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GetPositionIdsWherePortfolioEventBreak");
        }
    
        public virtual ObjectResult<RawFXRate> RawFXRate_GetLatest(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore)
        {
            var currencyIDParameter = currencyID.HasValue ?
                new ObjectParameter("CurrencyID", currencyID) :
                new ObjectParameter("CurrencyID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawFXRateIdToIgnoreParameter = rawFXRateIdToIgnore.HasValue ?
                new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore) :
                new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawFXRate>("RawFXRate_GetLatest", currencyIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawFXRate> RawFXRate_GetLatest(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore, MergeOption mergeOption)
        {
            var currencyIDParameter = currencyID.HasValue ?
                new ObjectParameter("CurrencyID", currencyID) :
                new ObjectParameter("CurrencyID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawFXRateIdToIgnoreParameter = rawFXRateIdToIgnore.HasValue ?
                new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore) :
                new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawFXRate>("RawFXRate_GetLatest", mergeOption, currencyIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawPrice> RawPrices_GetLatest(Nullable<int> instrumentMarketID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawPriceIdToIgnore)
        {
            var instrumentMarketIDParameter = instrumentMarketID.HasValue ?
                new ObjectParameter("InstrumentMarketID", instrumentMarketID) :
                new ObjectParameter("InstrumentMarketID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawPriceIdToIgnoreParameter = rawPriceIdToIgnore.HasValue ?
                new ObjectParameter("RawPriceIdToIgnore", rawPriceIdToIgnore) :
                new ObjectParameter("RawPriceIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawPrice>("RawPrices_GetLatest", instrumentMarketIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawPriceIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawPrice> RawPrices_GetLatest(Nullable<int> instrumentMarketID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawPriceIdToIgnore, MergeOption mergeOption)
        {
            var instrumentMarketIDParameter = instrumentMarketID.HasValue ?
                new ObjectParameter("InstrumentMarketID", instrumentMarketID) :
                new ObjectParameter("InstrumentMarketID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawPriceIdToIgnoreParameter = rawPriceIdToIgnore.HasValue ?
                new ObjectParameter("RawPriceIdToIgnore", rawPriceIdToIgnore) :
                new ObjectParameter("RawPriceIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawPrice>("RawPrices_GetLatest", mergeOption, instrumentMarketIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawPriceIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> FXRates_Roll(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("FXRates_Roll", updateUserIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> Prices_Roll(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("Prices_Roll", updateUserIdParameter);
        }
    
        public virtual ObjectResult<RawFXRate> RawFXRate_GetlatestForForward(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> forwardDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore)
        {
            var currencyIDParameter = currencyID.HasValue ?
                new ObjectParameter("CurrencyID", currencyID) :
                new ObjectParameter("CurrencyID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var forwardDateParameter = forwardDate.HasValue ?
                new ObjectParameter("ForwardDate", forwardDate) :
                new ObjectParameter("ForwardDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawFXRateIdToIgnoreParameter = rawFXRateIdToIgnore.HasValue ?
                new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore) :
                new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawFXRate>("RawFXRate_GetlatestForForward", currencyIDParameter, referenceDateParameter, forwardDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawFXRate> RawFXRate_GetlatestForForward(Nullable<int> currencyID, Nullable<System.DateTime> referenceDate, Nullable<System.DateTime> forwardDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawFXRateIdToIgnore, MergeOption mergeOption)
        {
            var currencyIDParameter = currencyID.HasValue ?
                new ObjectParameter("CurrencyID", currencyID) :
                new ObjectParameter("CurrencyID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var forwardDateParameter = forwardDate.HasValue ?
                new ObjectParameter("ForwardDate", forwardDate) :
                new ObjectParameter("ForwardDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawFXRateIdToIgnoreParameter = rawFXRateIdToIgnore.HasValue ?
                new ObjectParameter("RawFXRateIdToIgnore", rawFXRateIdToIgnore) :
                new ObjectParameter("RawFXRateIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawFXRate>("RawFXRate_GetlatestForForward", mergeOption, currencyIDParameter, referenceDateParameter, forwardDateParameter, entityRankingSchemeIdParameter, rawFXRateIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawAnalytic> RawAnalytic_GetLatest(Nullable<int> instrumentMarketID, Nullable<int> analyticTypeID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawAnalyticIdToIgnore)
        {
            var instrumentMarketIDParameter = instrumentMarketID.HasValue ?
                new ObjectParameter("InstrumentMarketID", instrumentMarketID) :
                new ObjectParameter("InstrumentMarketID", typeof(int));
    
            var analyticTypeIDParameter = analyticTypeID.HasValue ?
                new ObjectParameter("AnalyticTypeID", analyticTypeID) :
                new ObjectParameter("AnalyticTypeID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawAnalyticIdToIgnoreParameter = rawAnalyticIdToIgnore.HasValue ?
                new ObjectParameter("RawAnalyticIdToIgnore", rawAnalyticIdToIgnore) :
                new ObjectParameter("RawAnalyticIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawAnalytic>("RawAnalytic_GetLatest", instrumentMarketIDParameter, analyticTypeIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawAnalyticIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<RawAnalytic> RawAnalytic_GetLatest(Nullable<int> instrumentMarketID, Nullable<int> analyticTypeID, Nullable<System.DateTime> referenceDate, Nullable<int> entityRankingSchemeId, Nullable<int> rawAnalyticIdToIgnore, MergeOption mergeOption)
        {
            var instrumentMarketIDParameter = instrumentMarketID.HasValue ?
                new ObjectParameter("InstrumentMarketID", instrumentMarketID) :
                new ObjectParameter("InstrumentMarketID", typeof(int));
    
            var analyticTypeIDParameter = analyticTypeID.HasValue ?
                new ObjectParameter("AnalyticTypeID", analyticTypeID) :
                new ObjectParameter("AnalyticTypeID", typeof(int));
    
            var referenceDateParameter = referenceDate.HasValue ?
                new ObjectParameter("ReferenceDate", referenceDate) :
                new ObjectParameter("ReferenceDate", typeof(System.DateTime));
    
            var entityRankingSchemeIdParameter = entityRankingSchemeId.HasValue ?
                new ObjectParameter("EntityRankingSchemeId", entityRankingSchemeId) :
                new ObjectParameter("EntityRankingSchemeId", typeof(int));
    
            var rawAnalyticIdToIgnoreParameter = rawAnalyticIdToIgnore.HasValue ?
                new ObjectParameter("RawAnalyticIdToIgnore", rawAnalyticIdToIgnore) :
                new ObjectParameter("RawAnalyticIdToIgnore", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RawAnalytic>("RawAnalytic_GetLatest", mergeOption, instrumentMarketIDParameter, analyticTypeIDParameter, referenceDateParameter, entityRankingSchemeIdParameter, rawAnalyticIdToIgnoreParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> Analytic_Roll(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("Analytic_Roll", updateUserIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> RollExposure(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("RollExposure", updateUserIdParameter);
        }
    
        public virtual ObjectResult<Nullable<System.DateTime>> Beta_Roll(Nullable<int> updateUserId)
        {
            var updateUserIdParameter = updateUserId.HasValue ?
                new ObjectParameter("UpdateUserId", updateUserId) :
                new ObjectParameter("UpdateUserId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.DateTime>>("Beta_Roll", updateUserIdParameter);
        }
    
        public virtual int Fund_UpdateClientLoadDate(Nullable<int> fundId, Nullable<System.DateTime> loadDate)
        {
            var fundIdParameter = fundId.HasValue ?
                new ObjectParameter("FundId", fundId) :
                new ObjectParameter("FundId", typeof(int));
    
            var loadDateParameter = loadDate.HasValue ?
                new ObjectParameter("LoadDate", loadDate) :
                new ObjectParameter("LoadDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Fund_UpdateClientLoadDate", fundIdParameter, loadDateParameter);
        }
    }
}
