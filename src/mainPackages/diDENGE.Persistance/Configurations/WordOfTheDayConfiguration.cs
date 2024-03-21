using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class WordOfTheDayConfiguration : IEntityTypeConfiguration<WordOfTheDay>
{
    public void Configure(EntityTypeBuilder<WordOfTheDay> builder)
    {
        builder.ToTable("WordOfTheDays");
    }
}