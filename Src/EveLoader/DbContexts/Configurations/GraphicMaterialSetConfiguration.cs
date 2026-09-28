using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class GraphicMaterialSetConfiguration : IEntityTypeConfiguration<GraphicMaterialSet>
    {
        public void Configure(EntityTypeBuilder<GraphicMaterialSet> builder)
        {
        }
    }
}
