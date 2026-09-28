using EveLoaderEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EveLoader.DbContexts.Configurations
{
    public class FreelanceJobSchemaConfiguration : IEntityTypeConfiguration<FreelanceJobSchema>
    {
        public void Configure(EntityTypeBuilder<FreelanceJobSchema> builder)
        {
            builder.HasMany(f => f.Value)
                .WithOne()
                .HasForeignKey("FreelanceJobSchemaKey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FreelanceJobSchemaEntryConfiguration : IEntityTypeConfiguration<FreelanceJobSchemaEntry>
    {
        public void Configure(EntityTypeBuilder<FreelanceJobSchemaEntry> builder)
        {
            builder.HasOne(e => e.MaxContributionsPerParticipant)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaEntry>("MaxContributionsPerParticipantKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.MaxProgressPerContribution)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaEntry>("MaxProgressPerContributionKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ContributionMultiplier)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaEntry>("ContributionMultiplierKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Parameters)
                .WithOne()
                .HasForeignKey("FreelanceJobSchemaEntryKey")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class FreelanceJobSchemaParameterConfiguration : IEntityTypeConfiguration<FreelanceJobSchemaParameter>
    {
        public void Configure(EntityTypeBuilder<FreelanceJobSchemaParameter> builder)
        {
            builder.HasOne(p => p.Matcher)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaParameter>("MatcherKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.ItemDelivery)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaParameter>("ItemDeliveryKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.InventoryType)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaParameter>("InventoryTypeKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Boolean)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaParameter>("BooleanKey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class FreelanceJobSchemaItemDeliveryConfiguration : IEntityTypeConfiguration<FreelanceJobSchemaItemDelivery>
    {
        public void Configure(EntityTypeBuilder<FreelanceJobSchemaItemDelivery> builder)
        {
            builder.HasOne(d => d.DeliveryLocation)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaItemDelivery>("DeliveryLocationKey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

    public class FreelanceJobSchemaBooleanParameterConfiguration : IEntityTypeConfiguration<FreelanceJobSchemaBooleanParameter>
    {
        public void Configure(EntityTypeBuilder<FreelanceJobSchemaBooleanParameter> builder)
        {
            builder.HasOne(b => b.OptionFalse)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaBooleanParameter>("OptionFalseKey")
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(b => b.OptionTrue)
                .WithOne()
                .HasForeignKey<FreelanceJobSchemaBooleanParameter>("OptionTrueKey")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
