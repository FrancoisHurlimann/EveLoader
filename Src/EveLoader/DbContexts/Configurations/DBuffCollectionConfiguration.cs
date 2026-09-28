using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class DBuffCollectionConfiguration : IEntityTypeConfiguration<DBuffCollection>
    {
        public void Configure(EntityTypeBuilder<DBuffCollection> builder)
        {
            builder.HasMany(d => d.ItemModifiers)
                .WithOne()
                .HasForeignKey("DBuffCollectionId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.LocationGroupModifiers)
                .WithOne()
                .HasForeignKey("DBuffCollectionId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.LocationModifiers)
                .WithOne()
                .HasForeignKey("DBuffCollectionId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(d => d.LocationRequiredSkillModifiers)
                .WithOne()
                .HasForeignKey("DBuffCollectionId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
