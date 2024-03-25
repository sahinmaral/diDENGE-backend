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
                    Id = Guid.NewGuid().ToString(), Name = "Whatsapp",
                    PlaystoreId = "com.whatsapp",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Instagram",
                    PlaystoreId = "com.instagram.android",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Facebook",
                    PlaystoreId = "com.facebook.katana",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Twitter",
                    PlaystoreId = "com.twitter.android",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Snapchat",
                    PlaystoreId = "com.snapchat.android",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Youtube",
                    PlaystoreId = "com.google.android.youtube",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "LinkedIn",
                    PlaystoreId = "com.linkedin.android",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Telegram",
                    PlaystoreId = "org.telegram.messenger",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "Pinterest",
                    PlaystoreId = "com.pinterest",CreatedAt = DateTime.Now
                },
                new()
                {
                    Id = Guid.NewGuid().ToString(), Name = "TikTok",
                    PlaystoreId = "com.zhiliaoapp.musically",CreatedAt = DateTime.Now
                },
            }
        );
    }
}