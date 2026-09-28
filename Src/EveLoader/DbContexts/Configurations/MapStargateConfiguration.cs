using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapStargateConfiguration : IEntityTypeConfiguration<MapStargate>
    {
        public void Configure(EntityTypeBuilder<MapStargate> builder)
        {
            builder.OwnsOne(m => m.Position, position =>
            {
                position.Property(p => p.X).HasColumnName("PositionX");
                position.Property(p => p.Y).HasColumnName("PositionY");
                position.Property(p => p.Z).HasColumnName("PositionZ");
            });

            builder.OwnsOne(m => m.Destination, destination =>
            {
                destination.Property(d => d.SolarSystemID).HasColumnName("DestinationSolarSystemID");
                destination.Property(d => d.StargateID).HasColumnName("DestinationStargateID");
            });
        }
    }
}
