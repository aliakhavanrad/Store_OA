using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Data.POCO;

namespace Store.Data.Maps
{
    public class GroupMap
    {
        public GroupMap(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.AddedDate).HasDefaultValueSql("GetDate()");
            
        }
    }
}
