using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class UserAddictionLevelConfiguration : IEntityTypeConfiguration<UserAddictionLevel>
{
    public void Configure(EntityTypeBuilder<UserAddictionLevel> builder)
    {
        builder.ToTable("UserAddictionLevels");

        builder.HasOne(ual => ual.User)
            .WithMany()
            .HasForeignKey(ual => ual.UserId);
        
        builder.HasOne(ual => ual.AddictionLevel)
            .WithMany()
            .HasForeignKey(ual => ual.AddictionLevelId);
    }
}