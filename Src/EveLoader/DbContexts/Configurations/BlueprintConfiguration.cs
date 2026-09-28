using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class BlueprintConfiguration : IEntityTypeConfiguration<Blueprint>
    {
        public void Configure(EntityTypeBuilder<Blueprint> builder)
        {
            builder.HasOne(b => b.Activities)
                .WithOne()
                .HasForeignKey<BlueprintActivities>(ba => ba.BlueprintId);
        }
    }

    public class BlueprintActivitiesConfiguration : IEntityTypeConfiguration<BlueprintActivities>
    {
        public void Configure(EntityTypeBuilder<BlueprintActivities> builder)
        {
            builder.HasOne(a => a.Invention)
               .WithOne()
               .HasForeignKey<BlueprintActivities>(a => a.InventionId)
               .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.Manufacturing)
                .WithOne()
                .HasForeignKey<BlueprintActivities>(a => a.ManufacturingId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class BlueprintInventionConfiguration : IEntityTypeConfiguration<BlueprintInvention>
    {
        public void Configure(EntityTypeBuilder<BlueprintInvention> builder)
        {
            builder.HasMany(i => i.Materials)
                .WithOne()
                .HasForeignKey("BlueprintInventionId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(i => i.Products)
                .WithOne()
                .HasForeignKey("BlueprintInventionId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(i => i.Skills)
                .WithOne()
                .HasForeignKey("BlueprintInventionId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class BlueprintManufacturingConfiguration : IEntityTypeConfiguration<BlueprintManufacturing>
    {
        public void Configure(EntityTypeBuilder<BlueprintManufacturing> builder)
        {
            builder.HasMany(m => m.Materials)
                .WithOne()
                .HasForeignKey("BlueprintManufacturingId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Products)
                .WithOne()
                .HasForeignKey("BlueprintManufacturingId")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(m => m.Skills)
                .WithOne()
                .HasForeignKey("BlueprintManufacturingId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
