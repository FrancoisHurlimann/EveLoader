using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapPlanetConfiguration : IEntityTypeConfiguration<MapPlanet>
    {
        public void Configure(EntityTypeBuilder<MapPlanet> builder)
        {

        }
    }
}
