using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class DynamicItemAttributeConfiguration : IEntityTypeConfiguration<DynamicItemAttribute>
    {
        public void Configure(EntityTypeBuilder<DynamicItemAttribute> builder)
        {
            builder.HasMany(d => d.AttributeIDs)
                .WithOne()
                .HasForeignKey("DynamicItemAttributeId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.InputOutputMapping)
                .WithOne()
                .HasForeignKey("DynamicItemAttributeId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
