using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Data.Maps
{
    public class BrandMap
    {
        public BrandMap(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.AddedDate).HasDefaultValueSql("GetDate()");

        }
    }
}
