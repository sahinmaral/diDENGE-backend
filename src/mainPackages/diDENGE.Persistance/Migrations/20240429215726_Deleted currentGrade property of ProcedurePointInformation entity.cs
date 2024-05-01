using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class DeletedcurrentGradepropertyofProcedurePointInformationentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f4ccc923-b56c-406b-bacf-53e71dbbfc67");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "03756d3b-ac84-48b2-96c6-dab50cf59944");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "05882cb6-eb33-4bfc-a6b9-c3b3593eeb42");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "0c6ca4ab-474d-4391-931f-ea882b817984");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "2ff189ae-ab8f-4807-a83f-b5f2e8a50d92");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "46417384-aa5c-42a1-a21c-60c38eb77a8b");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "46c6762f-37ac-4bef-8a67-512b27ec50ae");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "57c005da-f65f-4057-92d6-7e0e0ba1fa0b");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d8fb1179-6d78-40ad-b4c1-dc5f72b5472e");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "eb6f94bf-8758-44a4-ad08-c3e106552789");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "fcaac685-79ee-414a-aa21-821bd1bd9cab");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "253b3de0-d33c-4775-8055-d3d896c61b25");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "31563b9a-4a83-40ea-91fa-67f4f1bd7417");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "4b0a51fc-e24e-4e37-bbb1-0304373bb518");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "6ac02d9a-c533-4232-9cad-d067c5bf3551");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "8d146607-8c91-4565-ab24-f8fd534130d5");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "9f16fa1b-744a-4fdb-b8c0-e25038831b58");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "a03236d3-3059-4b5c-812b-1fdb89c8ce0f");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "b7b6c884-2d53-4cca-8db3-2ba80f1fb608");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "d176271a-32b5-41d2-8ee9-4793c38e37e6");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "e1161032-9d78-4aee-8d09-a4e4a0accefd");

            migrationBuilder.DropColumn(
                name: "CurrentGrade",
                table: "ProcedurePointInformations");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<double>(
                name: "CurrentGrade",
                table: "ProcedurePointInformations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4ccc923-b56c-406b-bacf-53e71dbbfc67", "433d7e3a-e795-49c7-9317-2da3ce6ebe3c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "03756d3b-ac84-48b2-96c6-dab50cf59944", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Twitter", "com.twitter.android", null },
                    { "05882cb6-eb33-4bfc-a6b9-c3b3593eeb42", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LinkedIn", "com.linkedin.android", null },
                    { "0c6ca4ab-474d-4391-931f-ea882b817984", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Telegram", "org.telegram.messenger", null },
                    { "2ff189ae-ab8f-4807-a83f-b5f2e8a50d92", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instagram", "com.instagram.android", null },
                    { "46417384-aa5c-42a1-a21c-60c38eb77a8b", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TikTok", "com.zhiliaoapp.musically", null },
                    { "46c6762f-37ac-4bef-8a67-512b27ec50ae", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Youtube", "com.google.android.youtube", null },
                    { "57c005da-f65f-4057-92d6-7e0e0ba1fa0b", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whatsapp", "com.whatsapp", null },
                    { "d8fb1179-6d78-40ad-b4c1-dc5f72b5472e", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Facebook", "com.facebook.katana", null },
                    { "eb6f94bf-8758-44a4-ad08-c3e106552789", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snapchat", "com.snapchat.android", null },
                    { "fcaac685-79ee-414a-aa21-821bd1bd9cab", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinterest", "com.pinterest", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "253b3de0-d33c-4775-8055-d3d896c61b25", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "31563b9a-4a83-40ea-91fa-67f4f1bd7417", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "4b0a51fc-e24e-4e37-bbb1-0304373bb518", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "6ac02d9a-c533-4232-9cad-d067c5bf3551", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "8d146607-8c91-4565-ab24-f8fd534130d5", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "9f16fa1b-744a-4fdb-b8c0-e25038831b58", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "a03236d3-3059-4b5c-812b-1fdb89c8ce0f", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "b7b6c884-2d53-4cca-8db3-2ba80f1fb608", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "d176271a-32b5-41d2-8ee9-4793c38e37e6", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { "e1161032-9d78-4aee-8d09-a4e4a0accefd", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
