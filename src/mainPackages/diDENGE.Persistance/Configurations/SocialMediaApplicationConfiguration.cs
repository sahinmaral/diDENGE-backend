using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class SocialMediaApplicationConfiguration : IEntityTypeConfiguration<SocialMediaApplication>
{
    public void Configure(EntityTypeBuilder<SocialMediaApplication> builder)
    {
        builder.ToTable("SocialMediaApplications");
    }
}