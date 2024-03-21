using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class ProcedurePointInformationConfiguration : IEntityTypeConfiguration<ProcedurePointInformation>
{
    public void Configure(EntityTypeBuilder<ProcedurePointInformation> builder)
    {
        builder.ToTable("ProcedurePointInformations");
        
        builder.HasOne(ppi => ppi.User)
            .WithMany()
            .HasForeignKey(ppi => ppi.UserId);
        
        builder.HasOne(ppi => ppi.AddictionLevel)
            .WithMany()
            .HasForeignKey(ppi => ppi.AddictionLevelId);
    }
}