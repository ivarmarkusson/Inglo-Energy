namespace Inglo.Migrations
{
    using Models.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Inglo.Models.Inglodb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Inglo.Models.Inglodb";
        }

        protected override void Seed(Inglo.Models.Inglodb context)
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

            var products = new List<Product>
            {
                new Product { Name = "Energy Necklec"},
                new Product { Name = "Energy Pyramid"},
                new Product { Name = "Bath Salt"}
            };

            products.ForEach(x => context.Product.AddOrUpdate(y => y.Name, x));
            context.SaveChanges();
        }
    }
}
