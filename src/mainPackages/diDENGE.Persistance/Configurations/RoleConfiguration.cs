using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public sealed class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");
        builder.HasKey(x => x.Id);

        builder.HasData(
            new Role()
            {
                Id = "9f867519-977e-46da-87b7-eca5a30d7d0c", Name = "User", NormalizedName = "USER",
                ConcurrencyStamp = "c24248ef-e6a7-4ed5-be0f-5335e5cc6774"
            });
    }
}