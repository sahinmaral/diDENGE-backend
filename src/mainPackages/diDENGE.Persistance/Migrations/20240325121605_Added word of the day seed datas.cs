using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedwordofthedayseeddatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c9dd1587-7e07-49e1-8c88-39121243f142");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "23b08efb-2a72-42e8-9ef0-d275db95ec81");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "37de582b-d425-4f0c-8070-7ac2b41d4530");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "3d8d1f5a-d644-42df-895b-ce599e5c6d12");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "882c9990-4f7f-46dc-ad36-2091edf23336");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "a7bcfed8-389c-4109-9fe8-f85cb4c077a4");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "ab7b5a8e-0ceb-427e-83fd-a20855af564b");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "c04f044b-9263-4704-8b31-73fac08e1648");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d1887587-9d24-426f-8c1f-a45eb4aee3be");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d527300b-7c26-41ac-bfb9-631816017197");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "de5640ee-b119-4f45-99c8-6f916c32a6bd");

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 16, 5, 316, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 16, 5, 316, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 16, 5, 316, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 16, 5, 316, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 15, 16, 5, 316, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4f950a9f-99b8-4910-a5f4-2e0b5d0753f3", "5fa2340b-39d4-4e2b-ab39-53e379bfe040", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "10be8de8-6941-4f28-b447-b8736e0ee29a", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3998), "Pinterest", "com.pinterest", null },
                    { "12c1c2aa-2452-428d-bc23-a1cc9c4b129c", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3802), "Instagram", "com.instagram.android", null },
                    { "2a62a5f6-2cd7-438d-90d8-8d69bbd4169e", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3974), "Telegram", "org.telegram.messenger", null },
                    { "35e14787-d9a1-4bce-90a6-94b08c016814", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3737), "Whatsapp", "com.whatsapp", null },
                    { "4c635224-f54c-49cb-bded-c93f16a5db0a", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3831), "Facebook", "com.facebook.katana", null },
                    { "b56ffaa3-c256-4709-b32d-78fe47d7e070", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3860), "Twitter", "com.twitter.android", null },
                    { "de9531f1-5d81-4f5a-8688-8d6fe738523b", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3888), "Snapchat", "com.snapchat.android", null },
                    { "e0fd2a34-7420-44b6-b066-0cc9cacd3fd6", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3945), "LinkedIn", "com.linkedin.android", null },
                    { "f2ac8870-19b4-4c39-8b1d-123a581fabb7", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(3921), "Youtube", "com.google.android.youtube", null },
                    { "fe6b2e2d-650a-4db6-a46c-419b16f0f4bd", new DateTime(2024, 3, 25, 15, 16, 5, 322, DateTimeKind.Local).AddTicks(4027), "TikTok", "com.zhiliaoapp.musically", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "560fb86d-0d53-478a-86fd-777d2b07f80a", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7388), null },
                    { "56752829-14d9-4f2b-b763-ea451ffae326", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7441), null },
                    { "6097390b-95f6-4134-8671-dd3e619d3011", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7490), null },
                    { "66e18832-82b5-4c75-9046-53707754461a", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7566), null },
                    { "7e8a368b-c84d-4099-923a-dad71069d2b7", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7537), null },
                    { "99e30e8b-5a65-4b94-a843-1482931c20a0", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7470), null },
                    { "aba301d8-7932-4aca-923e-e90802b5642b", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7508), null },
                    { "b08b49ad-5de5-4819-8ea0-3d69ecd48240", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7326), null },
                    { "bb1dc1e8-7e58-44c6-8d2d-b1eb05ab858e", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7412), null },
                    { "c54133cc-dd6f-41e9-b337-6e76a4a1e872", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 3, 25, 15, 16, 5, 330, DateTimeKind.Local).AddTicks(7594), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4f950a9f-99b8-4910-a5f4-2e0b5d0753f3");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "10be8de8-6941-4f28-b447-b8736e0ee29a");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "12c1c2aa-2452-428d-bc23-a1cc9c4b129c");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "2a62a5f6-2cd7-438d-90d8-8d69bbd4169e");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "35e14787-d9a1-4bce-90a6-94b08c016814");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "4c635224-f54c-49cb-bded-c93f16a5db0a");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "b56ffaa3-c256-4709-b32d-78fe47d7e070");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "de9531f1-5d81-4f5a-8688-8d6fe738523b");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "e0fd2a34-7420-44b6-b066-0cc9cacd3fd6");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "f2ac8870-19b4-4c39-8b1d-123a581fabb7");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "fe6b2e2d-650a-4db6-a46c-419b16f0f4bd");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "560fb86d-0d53-478a-86fd-777d2b07f80a");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "56752829-14d9-4f2b-b763-ea451ffae326");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "6097390b-95f6-4134-8671-dd3e619d3011");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "66e18832-82b5-4c75-9046-53707754461a");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "7e8a368b-c84d-4099-923a-dad71069d2b7");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "99e30e8b-5a65-4b94-a843-1482931c20a0");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "aba301d8-7932-4aca-923e-e90802b5642b");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "b08b49ad-5de5-4819-8ea0-3d69ecd48240");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "bb1dc1e8-7e58-44c6-8d2d-b1eb05ab858e");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "c54133cc-dd6f-41e9-b337-6e76a4a1e872");

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 25, 10, 51, 21, 502, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c9dd1587-7e07-49e1-8c88-39121243f142", "7d6b8c49-349e-48a6-947d-dcaedcf8afe2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "23b08efb-2a72-42e8-9ef0-d275db95ec81", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8764), "Snapchat", "com.snapchat.android", null },
                    { "37de582b-d425-4f0c-8070-7ac2b41d4530", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8716), "Facebook", "com.facebook.katana", null },
                    { "3d8d1f5a-d644-42df-895b-ce599e5c6d12", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8626), "Whatsapp", "com.whatsapp", null },
                    { "882c9990-4f7f-46dc-ad36-2091edf23336", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8934), "TikTok", "com.zhiliaoapp.musically", null },
                    { "a7bcfed8-389c-4109-9fe8-f85cb4c077a4", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8878), "Pinterest", "com.pinterest", null },
                    { "ab7b5a8e-0ceb-427e-83fd-a20855af564b", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8797), "Youtube", "com.google.android.youtube", null },
                    { "c04f044b-9263-4704-8b31-73fac08e1648", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8735), "Twitter", "com.twitter.android", null },
                    { "d1887587-9d24-426f-8c1f-a45eb4aee3be", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8821), "LinkedIn", "com.linkedin.android", null },
                    { "d527300b-7c26-41ac-bfb9-631816017197", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8687), "Instagram", "com.instagram.android", null },
                    { "de5640ee-b119-4f45-99c8-6f916c32a6bd", new DateTime(2024, 3, 25, 10, 51, 21, 508, DateTimeKind.Local).AddTicks(8850), "Telegram", "org.telegram.messenger", null }
                });
        }
    }
}
