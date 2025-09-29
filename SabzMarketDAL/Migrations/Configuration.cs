namespace SabzMarketDAL.Migrations
{
    using SabzMarketDAL.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SabzMarketDAL.SabzMarketDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SabzMarketDAL.SabzMarketDbContext context)
        {
            

            context.Categories.AddOrUpdate(c=>c.Name,
                new Categorie { Name = "کود های شیمیایی" },
                new Categorie { Name = "کود های آلی " },
                new Categorie { Name = "کودهای بیولوژیک" },
                new Categorie { Name = "حشره کش ها " },
                new Categorie { Name = "علف کش ها" },
                new Categorie { Name = "سموم معدنی " },
                new Categorie { Name = "سموم آلی " }
                );
        }
    }
}
