using Core.Security.Entities;
using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class AddictionLevelConfiguration : IEntityTypeConfiguration<AddictionLevel>
{
    public void Configure(EntityTypeBuilder<AddictionLevel> builder)
    {
        builder.ToTable("AddictionLevels");

        builder.HasData(
            new AddictionLevel()
            {
                Id = "95cec253-2a7e-4466-b7e2-8aef25c437f6", Name = "Bağımlılık Yok", DailyLimit = 0, MinimumGrade = 41,
                MaximumGrade = 73, CreatedAt = DateTime.Now
            },
            new AddictionLevel()
            {
                Id = "610ce001-62a1-40bb-8edb-886959be71f1", Name = "Az Bağımlı", DailyLimit = 60, MinimumGrade = 74,
                MaximumGrade = 106, CreatedAt = DateTime.Now
            },
            new AddictionLevel()
            {
                Id = "4ac95367-eda8-49f2-9894-27421cbe256f", Name = "Orta Bağımlı", DailyLimit = 90, MinimumGrade = 107,
                MaximumGrade = 139, CreatedAt = DateTime.Now
            },
            new AddictionLevel()
            {
                Id = "f4b20091-1884-470a-8f05-6b25eba12a42", Name = "Yüksek Bağımlı", DailyLimit = 120,
                MinimumGrade = 140, MaximumGrade = 172, CreatedAt = DateTime.Now
            },
            new AddictionLevel()
            {
                Id = "16cbcf23-aff3-4aca-a1f3-01ddc4b79699", Name = "Çok Yüksek Bağımlı", DailyLimit = 150,
                MinimumGrade = 173, MaximumGrade = 205, CreatedAt = DateTime.Now
            }
        );
    }
}