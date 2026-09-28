using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class GraphicMaterialSetConfiguration : IEntityTypeConfiguration<GraphicMaterialSet>
    {
        public void Configure(EntityTypeBuilder<GraphicMaterialSet> builder)
        {
            builder.HasOne(g => g.ColorHull)
                .WithOne()
                .HasForeignKey<GraphicMaterialSet>("ColorHullKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.ColorPrimary)
                .WithOne()
                .HasForeignKey<GraphicMaterialSet>("ColorPrimaryKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.ColorSecondary)
                .WithOne()
                .HasForeignKey<GraphicMaterialSet>("ColorSecondaryKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(g => g.ColorWindow)
                .WithOne()
                .HasForeignKey<GraphicMaterialSet>("ColorWindowKey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
