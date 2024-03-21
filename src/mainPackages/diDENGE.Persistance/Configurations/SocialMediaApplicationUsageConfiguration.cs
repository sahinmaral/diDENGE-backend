using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class SocialMediaApplicationUsageConfiguration : IEntityTypeConfiguration<SocialMediaApplicationUsage>
{
    public void Configure(EntityTypeBuilder<SocialMediaApplicationUsage> builder)
    {
        builder.ToTable("SocialMediaApplicationUsages");
        
        builder.HasOne(smau => smau.User)
            .WithMany()
            .HasForeignKey(smau => smau.UserId);
        
        builder.HasOne(smau => smau.AddictionLevel)
            .WithMany()
            .HasForeignKey(smau => smau.AddictionLevelId);
    }
}