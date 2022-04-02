using Microsoft.EntityFrameworkCore;
using Store.Data.Maps;
using Store.Data.POCO;
using System;

namespace Store.Repo
{
    public class StoreDBContext: DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ProductMap(modelBuilder.Entity<Product>());
            new GroupMap(modelBuilder.Entity<Group>());
            new BrandMap(modelBuilder.Entity<Brand>());
        }
    }
}
