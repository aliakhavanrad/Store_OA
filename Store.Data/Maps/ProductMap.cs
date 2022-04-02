using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Maps
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ModelName).IsRequired();
            builder.Property(x => x.AddedDate).HasDefaultValueSql("GetDate()");
            builder.HasOne(x => x.Group).WithMany(x => x.Products).HasForeignKey(x => x.GroupID);
            builder.HasOne(x => x.Brand).WithMany(x => x.Products).HasForeignKey(x => x.BrandID);
        }
    }
}
