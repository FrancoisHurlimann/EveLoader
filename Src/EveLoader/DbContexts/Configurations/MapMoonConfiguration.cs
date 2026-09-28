using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class MapMoonConfiguration : IEntityTypeConfiguration<MapMoon>
    {
        public void Configure(EntityTypeBuilder<MapMoon> builder)
        {
  
        }
    }
}
