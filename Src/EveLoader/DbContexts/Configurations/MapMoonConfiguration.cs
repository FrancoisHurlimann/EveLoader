using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapMoonConfiguration : IEntityTypeConfiguration<MapMoon>
    {
        public void Configure(EntityTypeBuilder<MapMoon> builder)
        {
            builder.HasOne(m => m.Attributes)
                .WithOne()
                .HasForeignKey<MapMoon>("AttributesKey")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Statistics)
                .WithOne()
                .HasForeignKey<MapMoon>("StatisticsKey")
                .OnDelete(DeleteBehavior.Cascade);

            builder.OwnsOne(m => m.Position, position =>
            {
                position.Property(p => p.X).HasColumnName("PositionX");
                position.Property(p => p.Y).HasColumnName("PositionY");
                position.Property(p => p.Z).HasColumnName("PositionZ");
            });
        }
    }
}
