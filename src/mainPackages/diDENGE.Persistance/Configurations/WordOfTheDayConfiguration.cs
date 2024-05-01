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
            new WordOfTheDay { Id = "14831e89-5d31-4d5f-96ec-4f7e1c58462d", Content = "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "9ca587b8-e44e-4be0-8289-38205cd64ebd", Content = "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "37f1dc39-a9dc-450f-86a2-4a58e430795c", Content = "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "35fc2e4e-5ef7-45ea-9608-80706de22747", Content = "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "eb80bd4f-3ce9-4a95-89df-10fb99e19c43", Content = "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "3dd6e341-0c9d-4587-8f3b-3cc9b04855d7", Content = "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "96ec88d4-426b-4d19-a868-33af51c8760d", Content = "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "6a606036-f0c9-4b10-8711-f894f6edcd05", Content = "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "e0720a5b-1037-4826-aba3-59c187cd1908", Content = "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", CreatedAt = new DateTime(2024,01,01) },
            new WordOfTheDay { Id = "023434b7-6973-4c4e-af6c-abaf10570569", Content = "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", CreatedAt = new DateTime(2024,01,01) }
        );
    }
}