using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using WinFormswithEFSample.Entities.Product;

namespace WinFormswithEFSample.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("BASE")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductContext, WinFormswithEFSample.Migrations.Configuration>());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
