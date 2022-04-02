namespace PIIT_PRACTICAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PIIT_PRACTICAL.Data.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PIIT_PRACTICAL.Data.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
/*
            context.Database.ExecuteSqlCommand(" ALTER TABLE [Markets] NOCHECK CONSTRAINT FOREIGN KEY");
            context.Database.ExecuteSqlCommand(" ALTER TABLE [Coins] NOCHECK CONSTRAINT ALL");*/
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Coins]");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Markets]");
            context.Markets.Add(
                new Models.Market()
                {
                    Id = 1,
                    Name = "Binance",
                    Description = "Binance",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            context.Markets.Add(
               new Models.Market()
               {
                   Id = 2,
                   Name = "Houbi",
                   Description = "Houbi",
                   CreatedAt = DateTime.Now,
                   UpdatedAt = DateTime.Now
               }
           );

            context.Coins.Add(
                new Models.Coin()
                {
                    Name = "Binance",
                    LastPrice = 467758,
                    BaseAsset = "BTC",
                    QouteAsset = "USD",
                    MarketId = 1,
                    Volume24h = 39800,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
            context.Coins.Add(
               new Models.Coin()
               {
                   Name = "Ethereum",
                   LastPrice = 3485,
                   BaseAsset = "ETH",
                   QouteAsset = "USD",
                   MarketId = 1,
                   Volume24h = 22180,
                   CreatedAt = DateTime.Now,
                   UpdatedAt = DateTime.Now
               }
           );

            context.Coins.Add(
               new Models.Coin()
               {
                   Name = "Binance",
                   LastPrice = 467780,
                   BaseAsset = "BTC",
                   QouteAsset = "USD",
                   MarketId = 2,
                   Volume24h = 39900,
                   CreatedAt = DateTime.Now,
                   UpdatedAt = DateTime.Now
               }
           );
        }
    }
}
