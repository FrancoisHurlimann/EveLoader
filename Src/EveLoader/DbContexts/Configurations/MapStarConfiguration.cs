using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapStarConfiguration : IEntityTypeConfiguration<MapStar>
    {
        public void Configure(EntityTypeBuilder<MapStar> builder)
        {
            builder.OwnsOne(m => m.Statistics, statistics =>
            {
                statistics.Property(s => s.Age).HasColumnName("StatisticsAge");
                statistics.Property(s => s.Life).HasColumnName("StatisticsLife");
                statistics.Property(s => s.Luminosity).HasColumnName("StatisticsLuminosity");
                statistics.Property(s => s.SpectralClass).HasColumnName("StatisticsSpectralClass");
                statistics.Property(s => s.Temperature).HasColumnName("StatisticsTemperature");
            });
        }
    }
}
