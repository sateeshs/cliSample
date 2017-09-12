using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication.Api.Test
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
    {
        }
        /*
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        private TestDbContext GetContextWithData()
        {
            var options = new DbContextOptionsBuilder<TestDbContext>()
                              .UseInMemoryDatabase(Guid.NewGuid().ToString())
                              .Options;
            var context = new TestDbContext(options);

            var beerCategory = new Category { Id = 1, Name = "Beers" };
            var wineCategory = new Category { Id = 2, Name = "Wines" };
            context.Categories.Add(beerCategory);
            context.Categories.Add(wineCategory);

            context.Products.Add(new Product { Id = 1, Name = "La Trappe Isid'or", Category = beerCategory });
            context.Products.Add(new Product { Id = 2, Name = "St. Bernardus Abt 12", Category = beerCategory });
            context.Products.Add(new Product { Id = 3, Name = "Zundert", Category = beerCategory });
            context.Products.Add(new Product { Id = 4, Name = "La Trappe Blond", Category = beerCategory });
            context.Products.Add(new Product { Id = 5, Name = "La Trappe Bock", Category = beerCategory });
            context.Products.Add(new Product { Id = 6, Name = "St. Bernardus Tripel", Category = beerCategory });
            context.Products.Add(new Product { Id = 7, Name = "Grottenbier Bruin", Category = beerCategory });
            context.Products.Add(new Product { Id = 8, Name = "St. Bernardus Pater 6", Category = beerCategory });
            context.Products.Add(new Product { Id = 9, Name = "La Trappe Quadrupel", Category = beerCategory });
            context.Products.Add(new Product { Id = 10, Name = "Westvleteren 12", Category = beerCategory });
            context.Products.Add(new Product { Id = 11, Name = "Leffe Bruin", Category = beerCategory });
            context.Products.Add(new Product { Id = 12, Name = "Leffe Royale", Category = beerCategory });
            context.SaveChanges();

            return context;
        }*/

    }
}
