using diDENGE.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace diDENGE.Persistance.Configurations;

public class WordOfTheDayConfiguration : IEntityTypeConfiguration<WordOfTheDay>
{
    public void Configure(EntityTypeBuilder<WordOfTheDay> builder)
    {
        builder.ToTable("WordOfTheDays");
        
        builder.HasData(
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", CreatedAt = DateTime.Now },
            new WordOfTheDay { Id = Guid.NewGuid().ToString(), Content = "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", CreatedAt = DateTime.Now }
        );
    }
}