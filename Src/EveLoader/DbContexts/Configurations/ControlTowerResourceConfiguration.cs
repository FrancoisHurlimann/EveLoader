using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class ControlTowerResourceConfiguration : IEntityTypeConfiguration<ControlTowerResource>
    {
        public void Configure(EntityTypeBuilder<ControlTowerResource> builder)
        {
            builder.HasMany(c => c.Resources)
                .WithOne()
                .HasForeignKey("ControlTowerResourceKey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
