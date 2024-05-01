using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIdpropertyofRoleandWordOfTheDayentitiesasstaticvalueforpreventingupdateeverytimemigrationoccurs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "99a4d7a6-d5ac-41cf-bc11-e1187f11d8c0");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "164b41e0-7434-408c-a72e-dd84545fc266");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "4d451c71-a3ac-4baf-bdd1-f31cce5d3bd0");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "51984c42-0ac8-4539-b58e-00cd48a7fe34");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "78d21b42-34cf-4180-b0b6-39661df16f5d");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "7d7f61d1-7626-4899-918f-cf47f6c7853a");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "8a1a3a89-6a11-4a80-a3b3-365725493e4f");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "9a9e9ff4-93db-4b0b-afe1-370723f3664f");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "b7f30572-da99-428b-8467-92a24212f365");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d625b39b-43a9-416d-b229-b0d3cf981c0f");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "e5c9cae4-2d4c-45d3-8a82-43ea107f9dcb");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "1de8bede-f92b-4a94-8af3-6b15fe86dea1");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "4ab2ae6f-2be4-4a6b-a884-d0b8bda3fe31");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "66cc2e47-7253-43a8-9760-84fa7a74b57c");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "7de044c6-9d6e-4b75-b5e2-17211abdb9b3");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "978ac017-ebd5-4b96-92c3-821560081e98");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "9811bd23-26c8-42eb-a33b-411861f576f1");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "a2f7fdae-ef64-47e0-a344-a47ff144b9f2");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "b1e7e772-4b93-4765-a50f-86d083f92da5");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "d8a7a6a5-1658-46af-8964-05ab7243be43");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "e44af59a-a282-42ab-beea-39e7ae581e25");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f867519-977e-46da-87b7-eca5a30d7d0c", "02189894-f51a-4ad2-8e78-d4b7f240600c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "08051b49-4847-4787-9983-899285774427", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twitter", "com.twitter.android", null },
                    { "084ee64b-c8e6-40e2-949e-bfa29b205699", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TikTok", "com.zhiliaoapp.musically", null },
                    { "41d3cd5b-e785-44cb-939b-3c0e11b14a8a", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whatsapp", "com.whatsapp", null },
                    { "61b5b168-0027-4e62-9eab-681a5c69ad82", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinterest", "com.pinterest", null },
                    { "6ae0c69e-20e8-43b9-acd7-9a438cd1a5d9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facebook", "com.facebook.katana", null },
                    { "c84c5b3e-9a2b-48db-9254-fbfb347dda62", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LinkedIn", "com.linkedin.android", null },
                    { "d47cb6a0-6526-4af4-866c-ae012e2938f3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", "com.instagram.android", null },
                    { "d5cafb1f-c7ad-4a17-b0df-aedf9825f057", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telegram", "org.telegram.messenger", null },
                    { "d8854cf2-5e6c-4cfd-8eb3-356d7d208aee", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youtube", "com.google.android.youtube", null },
                    { "fa4ea881-b41e-4240-9077-595943f77a3e", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snapchat", "com.snapchat.android", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "023434b7-6973-4c4e-af6c-abaf10570569", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "14831e89-5d31-4d5f-96ec-4f7e1c58462d", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "35fc2e4e-5ef7-45ea-9608-80706de22747", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "37f1dc39-a9dc-450f-86a2-4a58e430795c", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "3dd6e341-0c9d-4587-8f3b-3cc9b04855d7", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "6a606036-f0c9-4b10-8711-f894f6edcd05", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "96ec88d4-426b-4d19-a868-33af51c8760d", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "9ca587b8-e44e-4be0-8289-38205cd64ebd", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "e0720a5b-1037-4826-aba3-59c187cd1908", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "eb80bd4f-3ce9-4a95-89df-10fb99e19c43", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f867519-977e-46da-87b7-eca5a30d7d0c");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "08051b49-4847-4787-9983-899285774427");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "084ee64b-c8e6-40e2-949e-bfa29b205699");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "41d3cd5b-e785-44cb-939b-3c0e11b14a8a");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "61b5b168-0027-4e62-9eab-681a5c69ad82");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "6ae0c69e-20e8-43b9-acd7-9a438cd1a5d9");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "c84c5b3e-9a2b-48db-9254-fbfb347dda62");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d47cb6a0-6526-4af4-866c-ae012e2938f3");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d5cafb1f-c7ad-4a17-b0df-aedf9825f057");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d8854cf2-5e6c-4cfd-8eb3-356d7d208aee");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "fa4ea881-b41e-4240-9077-595943f77a3e");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "023434b7-6973-4c4e-af6c-abaf10570569");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "14831e89-5d31-4d5f-96ec-4f7e1c58462d");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "35fc2e4e-5ef7-45ea-9608-80706de22747");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "37f1dc39-a9dc-450f-86a2-4a58e430795c");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "3dd6e341-0c9d-4587-8f3b-3cc9b04855d7");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "6a606036-f0c9-4b10-8711-f894f6edcd05");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "96ec88d4-426b-4d19-a868-33af51c8760d");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "9ca587b8-e44e-4be0-8289-38205cd64ebd");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "e0720a5b-1037-4826-aba3-59c187cd1908");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "eb80bd4f-3ce9-4a95-89df-10fb99e19c43");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99a4d7a6-d5ac-41cf-bc11-e1187f11d8c0", "02655f16-a57b-4213-9154-f78f7d39a48e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "164b41e0-7434-408c-a72e-dd84545fc266", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", "com.instagram.android", null },
                    { "4d451c71-a3ac-4baf-bdd1-f31cce5d3bd0", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telegram", "org.telegram.messenger", null },
                    { "51984c42-0ac8-4539-b58e-00cd48a7fe34", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whatsapp", "com.whatsapp", null },
                    { "78d21b42-34cf-4180-b0b6-39661df16f5d", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youtube", "com.google.android.youtube", null },
                    { "7d7f61d1-7626-4899-918f-cf47f6c7853a", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinterest", "com.pinterest", null },
                    { "8a1a3a89-6a11-4a80-a3b3-365725493e4f", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TikTok", "com.zhiliaoapp.musically", null },
                    { "9a9e9ff4-93db-4b0b-afe1-370723f3664f", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LinkedIn", "com.linkedin.android", null },
                    { "b7f30572-da99-428b-8467-92a24212f365", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twitter", "com.twitter.android", null },
                    { "d625b39b-43a9-416d-b229-b0d3cf981c0f", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snapchat", "com.snapchat.android", null },
                    { "e5c9cae4-2d4c-45d3-8a82-43ea107f9dcb", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facebook", "com.facebook.katana", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "1de8bede-f92b-4a94-8af3-6b15fe86dea1", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "4ab2ae6f-2be4-4a6b-a884-d0b8bda3fe31", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "66cc2e47-7253-43a8-9760-84fa7a74b57c", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "7de044c6-9d6e-4b75-b5e2-17211abdb9b3", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "978ac017-ebd5-4b96-92c3-821560081e98", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "9811bd23-26c8-42eb-a33b-411861f576f1", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "a2f7fdae-ef64-47e0-a344-a47ff144b9f2", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "b1e7e772-4b93-4765-a50f-86d083f92da5", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "d8a7a6a5-1658-46af-8964-05ab7243be43", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "e44af59a-a282-42ab-beea-39e7ae581e25", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
