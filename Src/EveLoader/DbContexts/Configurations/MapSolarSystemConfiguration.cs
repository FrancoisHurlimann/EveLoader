using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapSolarSystemConfiguration : IEntityTypeConfiguration<MapSolarSystem>
    {
        public void Configure(EntityTypeBuilder<MapSolarSystem> builder)
        {
            builder.OwnsOne(m => m.Position, position =>
            {
                position.Property(p => p.X).HasColumnName("PositionX");
                position.Property(p => p.Y).HasColumnName("PositionY");
                position.Property(p => p.Z).HasColumnName("PositionZ");
            });

            builder.OwnsOne(m => m.Position2D, position2D =>
            {
                position2D.Property(p => p.X).HasColumnName("Position2DX");
                position2D.Property(p => p.Y).HasColumnName("Position2DY");
            });
        }
    }
}
