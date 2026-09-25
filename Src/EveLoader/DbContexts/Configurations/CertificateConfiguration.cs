using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            builder.HasMany(c => c.RecommendedFor)
                .WithOne()
                .HasForeignKey("CertificateKey")
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.SkillTypes)
                .WithOne()
                .HasForeignKey("CertificateKey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
