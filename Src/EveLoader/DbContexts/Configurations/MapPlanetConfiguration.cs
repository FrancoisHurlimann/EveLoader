using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapPlanetConfiguration : IEntityTypeConfiguration<MapPlanet>
    {
        public void Configure(EntityTypeBuilder<MapPlanet> builder)
        {
            builder.HasOne(m => m.Attributes)
                .WithOne()
                .HasForeignKey<MapPlanet>("AttributesKey")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Statistics)
                .WithOne()
                .HasForeignKey<MapPlanet>("StatisticsKey")
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
