using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class ContrabandTypeConfiguration : IEntityTypeConfiguration<ContrabandType>
    {
        public void Configure(EntityTypeBuilder<ContrabandType> builder)
        {
            builder.HasMany(c => c.Factions)
                .WithOne()
                .HasForeignKey("ContrabandTypeKey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
