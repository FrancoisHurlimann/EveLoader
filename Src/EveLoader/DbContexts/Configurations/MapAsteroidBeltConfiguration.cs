using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapAsteroidBeltConfiguration : IEntityTypeConfiguration<MapAsteroidBelt>
    {
        public void Configure(EntityTypeBuilder<MapAsteroidBelt> builder)
        {
            //builder.HasOne(m => m.MapAsteroidBeltPosition)
            //    .WithOne()
            //    .HasForeignKey<MapAsteroidBelt>("MapAsteroidBeltPositionId")
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.HasOne(m => m.Statistics)
            //    .WithOne()
            //    .HasForeignKey<MapAsteroidBelt>("StatisticsId")
            //    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
