using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddedcountpropertyofProcedurePointInformationentityforcheckinghowmanytimesprocedurehasappliedtouser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "3d6d4db2-1b90-4d8c-833b-8b46cd26d70b");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "14a08b23-ab67-4d71-8d89-017783b5f63e");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "61e3bf50-3f7c-4e2f-8482-1d26cb99a355");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "85421692-8036-4968-85a5-ab8383dd8e60");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "955a5468-9aa3-485a-9d33-8aad3766ad2c");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "9c29b578-e746-4ccd-ada0-e9c40617b232");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "ad3afbca-1ef1-4bad-b0dc-513879df7eeb");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "d0ee4cec-171e-44b1-9f91-1318c3bb6c77");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "e45ee300-0de3-4969-9f88-49c0d33bc82d");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "f1656b9b-f898-49fb-ad52-99d15f99a5b6");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "f167fae4-a421-4138-80bd-d2a0e238e023");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "07a6b99b-2048-41ab-b3a8-4dbbed760cce");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "0fbc3890-f860-40ba-8a19-0ba43554d0d7");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "150c66aa-e80a-4612-be0b-3358216f61f9");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "16180a53-7a4d-4323-8b36-6a3c872559c4");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "60b40725-fe25-4409-8f11-57aaf917e2a1");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "82c8915d-f731-481b-a3d9-3ac3403b0baa");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "9768f252-ae63-4bd6-9de2-08a8625b6a37");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "a9fffad5-1cca-4a30-8322-ee29af81ca0a");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "c78ee64f-d26d-4ce0-b446-b929e358c07a");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "de2754ed-a4b3-4e38-bf21-54ba27b49326");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "ProcedurePointInformations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "a28a5be9-e694-40e8-8a31-9c282d61157d",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d2337816-2312-44e0-8e6b-dab47a7ca01d",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b",
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Count",
                table: "ProcedurePointInformations");

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 311, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 311, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 311, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 311, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 311, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "a28a5be9-e694-40e8-8a31-9c282d61157d",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d2337816-2312-44e0-8e6b-dab47a7ca01d",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d6d4db2-1b90-4d8c-833b-8b46cd26d70b", "a65ee39f-827c-4f23-bcb9-701671404ca3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "14a08b23-ab67-4d71-8d89-017783b5f63e", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7147), "Snapchat", "com.snapchat.android", null },
                    { "61e3bf50-3f7c-4e2f-8482-1d26cb99a355", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7203), "LinkedIn", "com.linkedin.android", null },
                    { "85421692-8036-4968-85a5-ab8383dd8e60", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7089), "Facebook", "com.facebook.katana", null },
                    { "955a5468-9aa3-485a-9d33-8aad3766ad2c", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7247), "Pinterest", "com.pinterest", null },
                    { "9c29b578-e746-4ccd-ada0-e9c40617b232", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7069), "Instagram", "com.instagram.android", null },
                    { "ad3afbca-1ef1-4bad-b0dc-513879df7eeb", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7227), "Telegram", "org.telegram.messenger", null },
                    { "d0ee4cec-171e-44b1-9f91-1318c3bb6c77", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(6969), "Whatsapp", "com.whatsapp", null },
                    { "e45ee300-0de3-4969-9f88-49c0d33bc82d", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7280), "TikTok", "com.zhiliaoapp.musically", null },
                    { "f1656b9b-f898-49fb-ad52-99d15f99a5b6", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7118), "Twitter", "com.twitter.android", null },
                    { "f167fae4-a421-4138-80bd-d2a0e238e023", new DateTime(2024, 4, 1, 17, 34, 12, 321, DateTimeKind.Local).AddTicks(7180), "Youtube", "com.google.android.youtube", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "07a6b99b-2048-41ab-b3a8-4dbbed760cce", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2550), null },
                    { "0fbc3890-f860-40ba-8a19-0ba43554d0d7", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2867), null },
                    { "150c66aa-e80a-4612-be0b-3358216f61f9", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2650), null },
                    { "16180a53-7a4d-4323-8b36-6a3c872559c4", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(3009), null },
                    { "60b40725-fe25-4409-8f11-57aaf917e2a1", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2925), null },
                    { "82c8915d-f731-481b-a3d9-3ac3403b0baa", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2839), null },
                    { "9768f252-ae63-4bd6-9de2-08a8625b6a37", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2896), null },
                    { "a9fffad5-1cca-4a30-8322-ee29af81ca0a", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2981), null },
                    { "c78ee64f-d26d-4ce0-b446-b929e358c07a", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2626), null },
                    { "de2754ed-a4b3-4e38-bf21-54ba27b49326", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 4, 1, 17, 34, 12, 334, DateTimeKind.Local).AddTicks(2948), null }
                });
        }
    }
}
