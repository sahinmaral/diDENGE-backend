using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class SocialMediaApplicationConfiguration : IEntityTypeConfiguration<SocialMediaApplication>
{
    public void Configure(EntityTypeBuilder<SocialMediaApplication> builder)
    {
        builder.ToTable("SocialMediaApplications");

        builder.HasData(
            new List<SocialMediaApplication>()
            {
                new()
                {
                    Id = "41d3cd5b-e785-44cb-939b-3c0e11b14a8a", Name = "Whatsapp",
                    PlaystoreId = "com.whatsapp",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id ="d47cb6a0-6526-4af4-866c-ae012e2938f3", Name = "Instagram",
                    PlaystoreId = "com.instagram.android",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "6ae0c69e-20e8-43b9-acd7-9a438cd1a5d9", Name = "Facebook",
                    PlaystoreId = "com.facebook.katana",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "08051b49-4847-4787-9983-899285774427", Name = "Twitter",
                    PlaystoreId = "com.twitter.android",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "fa4ea881-b41e-4240-9077-595943f77a3e", Name = "Snapchat",
                    PlaystoreId = "com.snapchat.android",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "d8854cf2-5e6c-4cfd-8eb3-356d7d208aee", Name = "Youtube",
                    PlaystoreId = "com.google.android.youtube",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "c84c5b3e-9a2b-48db-9254-fbfb347dda62", Name = "LinkedIn",
                    PlaystoreId = "com.linkedin.android",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "d5cafb1f-c7ad-4a17-b0df-aedf9825f057", Name = "Telegram",
                    PlaystoreId = "org.telegram.messenger",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "61b5b168-0027-4e62-9eab-681a5c69ad82", Name = "Pinterest",
                    PlaystoreId = "com.pinterest",CreatedAt = new DateTime(2024,01,01)
                },
                new()
                {
                    Id = "084ee64b-c8e6-40e2-949e-bfa29b205699", Name = "TikTok",
                    PlaystoreId = "com.zhiliaoapp.musically",CreatedAt = new DateTime(2024,01,01)
                },
            }
        );
    }
}