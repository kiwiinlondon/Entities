using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Odey.Framework.Keeley.Entities;
using Odey.Framework.Keeley;
using Odey.Framework.Keeley.Entities.Caches;
using Odey.Framework.Keeley.Entities.Enums;
using Odey.Framework.Keeley.Entities.Interfaces;
using Odey.StaticServices.Clients;
using ServiceModelEx;

namespace Odey.Framework.KeeleyEntitiesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KeeleyModel(SecurityCallStackContext.Current))
            {
                var ret = context.FundNetAssetValues
                    .Include(a => a.Fund.LegalEntity)
                    .Where(a => a.ReferenceDate == DateTime.Today
                                && a.Fund.IsActive
                                && (a.Fund.FundTypeId == (int) FundTypeIds.Hedge || a.Fund.FundTypeId == (int) FundTypeIds.UCITS))
                    .ToList()
                     .OrderBy(f => f.Fund.Name)
                     .ToList();
                ret = ret;
            }
        }

        static void TestCache()
        {
            IdentifierTypeCache cache = new IdentifierTypeCache();
            IdentifierType id = cache.Get(IdentifierTypeIds.IsoCode);

        }

        static void TestGetByIso()
        {
            using (var context = new KeeleyModel())
            {
                //context.RollPortfolioSettlementDate(
               // context.PortfolioPositionAccountMovementRollForward();
                Region region = context.Regions.Where(a => a.IsoCode == "GX").FirstOrDefault();
            }
        }
        static void CreateUser()
        {
            using (var context = new KeeleyModel())
            {
                ApplicationUser user = new ApplicationUser();
                user.Email = "John.Doe@odey.com";
                user.Name = "John Doe";
                user.WindowsLogin = @"OAM\DoeJ";
                //user.UpdateUserID = 1;
                context.ApplicationUsers.Add(user);
                context.SaveChanges();
            }

        }

        static void CreateRegion()
        {
            using (var context = new KeeleyModel())
            {
                Region region = new Region();
                region.IsoCode = "AX";
                region.Name = "Asia Excl Japan";
                //region.UpdateUserID = 1;
                context.Regions.Add(region);
                context.SaveChanges();
            }

        }

        static void CreateCountry()
        {
            using (var context = new KeeleyModel())
            {
                Country country = new Country();
                country.IsoCode = "BD";
                country.Name = "Bangladesh";
                //country.UpdateUserID = 1;
                context.Countries.Add(country);
                context.SaveChanges();
            }

        }

        static void CreateIssuer()
        {
            Instrument i = null;
            using (var context = new KeeleyModel(null))
            {
                i = context.Instruments.Include("UnderlyingRelationship.Underlyer.InstrumentMarkets").Include("InstrumentMarkets").Include("Bond").Include("InstrumentClass.ParentInstrumentClassRelationships")
                    .Where(a => a.InstrumentID == 29351).FirstOrDefault();
                
            }

            InstrumentClient instrumentClient = new InstrumentClient();

            Instrument instrument = instrumentClient.GetForIdentifierSettingUpIfNotPresent(IdentifierTypeIds.BBGlobalId, "BBG000BD84L8", false, 4);

            using (var context = new KeeleyModel(null))
            {
                InstrumentMarket im = new InstrumentMarket();
              
                context.InstrumentMarkets.Add(im);
                im.Instrument = instrument;
                context.SaveChanges();
            }

        }

        static void Update()
        {
            using (var context = new KeeleyModel())
            {

                InstrumentClass c = context.InstrumentClasses.Where(a => a.InstrumentClassID == 1).FirstOrDefault();
                c.Name = "All";
                
                //context.ApplicationUsers.AddObject(user);
                context.SaveChanges();

            }
        }

        static void Delete()
        {
            using (var context = new KeeleyModel())
            {

                ApplicationUser user = context.ApplicationUsers.Where(a => a.UserID == 20).FirstOrDefault();
                //user.UpdateUserID = 20;
              //  context.AcceptAllChanges();
             //   context.DeleteObject(user);
                //context.ApplicationUsers.DeleteObject(user);
                //context.ApplicationUsers.AddObject(user);
                context.SaveChanges();

            }
        }

    }
}
