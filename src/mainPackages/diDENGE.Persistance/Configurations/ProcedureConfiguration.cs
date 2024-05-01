using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class ProcedureConfiguration : IEntityTypeConfiguration<Procedure>
{
    public void Configure(EntityTypeBuilder<Procedure> builder)
    {
        builder.ToTable("Procedures");
        
        builder.HasData(
            new Procedure()
            {
                Id = "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b", Name = "Takdir", CreatedAt = new DateTime(2024,01,01)
            },
            new Procedure()
            {
                Id = "d2337816-2312-44e0-8e6b-dab47a7ca01d", Name = "Hatırlatıcı", CreatedAt = new DateTime(2024,01,01)
            },
            new Procedure()
            {
                Id = "a28a5be9-e694-40e8-8a31-9c282d61157d", Name = "Uyarı", CreatedAt = new DateTime(2024,01,01)
            }
        );
    }
}