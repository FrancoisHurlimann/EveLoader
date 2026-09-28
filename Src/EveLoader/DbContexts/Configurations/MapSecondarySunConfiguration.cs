using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapSecondarySunConfiguration : IEntityTypeConfiguration<MapSecondarySun>
    {
        public void Configure(EntityTypeBuilder<MapSecondarySun> builder)
        {
            builder.OwnsOne(m => m.Position, position =>
            {
                position.Property(p => p.X).HasColumnName("PositionX");
                position.Property(p => p.Y).HasColumnName("PositionY");
                position.Property(p => p.Z).HasColumnName("PositionZ");
            });
        }
    }
}
