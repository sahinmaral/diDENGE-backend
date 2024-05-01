using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedseeddataatprocedureentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "b2bc0810-4260-4624-8e27-6beb2e795a1d");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "06450876-9517-4d9b-b285-cf35971bc01a");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "28c7f96b-8209-4cc2-94e3-6413900bea34");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "2cee6fcf-5a3b-4518-b984-6c21ebfec409");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "40d7d007-ab5e-4af0-8bc0-45a1bdc29171");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "9169c110-cc72-4003-8b48-eb3539ff1eb2");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "917e89dd-8550-4be9-a06a-1e90197c9747");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "93f104fd-23cf-4bbb-9557-b18d322723b6");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "bd078f30-e9e4-4b63-8edb-8ca944aaa829");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "f2770b5d-c32c-4e9b-a137-396ae2c35a70");

            migrationBuilder.DeleteData(
                table: "SocialMediaApplications",
                keyColumn: "Id",
                keyValue: "fb0df336-3372-4b7c-88ae-c46ae9752de4");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "1917bb65-ba01-4869-98c1-311742b3f406");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "3fb1047b-3928-4ce1-980e-e76ef3eaac05");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "57a3a6cc-2e7d-468f-ae7a-485f317b9dff");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "663f7517-f62a-4716-962e-3a664acc74ef");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "72b70685-e7b0-4aaf-8de6-9de097f566a4");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "bdd29a4a-982f-4e9f-b825-89bf436c071c");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "c251806f-8ec2-4406-a6e1-c3e3a1da0c10");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "d0651fb3-5a8e-4928-aa15-07db6af84325");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "e949ec38-e151-4f5c-a125-0ef512926ebf");

            migrationBuilder.DeleteData(
                table: "WordOfTheDays",
                keyColumn: "Id",
                keyValue: "efe31465-5895-4f26-a230-63eb3ea84e45");

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

            migrationBuilder.InsertData(
                table: "Procedures",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "a28a5be9-e694-40e8-8a31-9c282d61157d", new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(453), "Uyarı", null },
                    { "d2337816-2312-44e0-8e6b-dab47a7ca01d", new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(434), "Hatırlatıcı", null },
                    { "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b", new DateTime(2024, 4, 1, 17, 34, 12, 313, DateTimeKind.Local).AddTicks(376), "Takdir", null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "a28a5be9-e694-40e8-8a31-9c282d61157d");

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d2337816-2312-44e0-8e6b-dab47a7ca01d");

            migrationBuilder.DeleteData(
                table: "Procedures",
                keyColumn: "Id",
                keyValue: "d5cbddb9-e315-4c56-8ef7-bcaeb68e7b9b");

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

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 15, 7, 46, 867, DateTimeKind.Local).AddTicks(7351));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b2bc0810-4260-4624-8e27-6beb2e795a1d", "b5b087ee-faf9-4e5a-8680-10bcccd5ab3f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "SocialMediaApplications",
                columns: new[] { "Id", "CreatedAt", "Name", "PlaystoreId", "UpdatedAt" },
                values: new object[,]
                {
                    { "06450876-9517-4d9b-b285-cf35971bc01a", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9398), "Instagram", "com.instagram.android", null },
                    { "28c7f96b-8209-4cc2-94e3-6413900bea34", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9611), "Pinterest", "com.pinterest", null },
                    { "2cee6fcf-5a3b-4518-b984-6c21ebfec409", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9592), "Telegram", "org.telegram.messenger", null },
                    { "40d7d007-ab5e-4af0-8bc0-45a1bdc29171", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9465), "Twitter", "com.twitter.android", null },
                    { "9169c110-cc72-4003-8b48-eb3539ff1eb2", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9494), "Snapchat", "com.snapchat.android", null },
                    { "917e89dd-8550-4be9-a06a-1e90197c9747", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9649), "TikTok", "com.zhiliaoapp.musically", null },
                    { "93f104fd-23cf-4bbb-9557-b18d322723b6", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9432), "Facebook", "com.facebook.katana", null },
                    { "bd078f30-e9e4-4b63-8edb-8ca944aaa829", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9289), "Whatsapp", "com.whatsapp", null },
                    { "f2770b5d-c32c-4e9b-a137-396ae2c35a70", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9527), "Youtube", "com.google.android.youtube", null },
                    { "fb0df336-3372-4b7c-88ae-c46ae9752de4", new DateTime(2024, 4, 1, 15, 7, 46, 876, DateTimeKind.Local).AddTicks(9559), "LinkedIn", "com.linkedin.android", null }
                });

            migrationBuilder.InsertData(
                table: "WordOfTheDays",
                columns: new[] { "Id", "Content", "CreatedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { "1917bb65-ba01-4869-98c1-311742b3f406", "Hayatınızı sosyal medyadan yönlendirmeyin, siz yönlendirin.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(635), null },
                    { "3fb1047b-3928-4ce1-980e-e76ef3eaac05", "Klavyenizi bırakın ve insanların gözlerine bakın, gerçek bağlantılar o anda kurulur.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(806), null },
                    { "57a3a6cc-2e7d-468f-ae7a-485f317b9dff", "Her 'beğeni' kalbinizden bir parça çalır. Gerçek değeri, kendiniz olmakta bulun.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(692), null },
                    { "663f7517-f62a-4716-962e-3a664acc74ef", "Bağımlılığı azaltın, gerçek dünyanın renklerini fark edin.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(721), null },
                    { "72b70685-e7b0-4aaf-8de6-9de097f566a4", "Hayatınızdaki değeri, ekranın arkasında değil, gerçek dünyada yaşadığınız anlarda bulacaksınız.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(519), null },
                    { "bdd29a4a-982f-4e9f-b825-89bf436c071c", "Sosyal medya, hayatınızın sahnesi olmamalı, sadece bir araç olarak kullanın.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(834), null },
                    { "c251806f-8ec2-4406-a6e1-c3e3a1da0c10", "Gerçek mutluluk, ekranın parladığı kadar değil, gökyüzünün altında yaşadığınız anlardadır.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(663), null },
                    { "d0651fb3-5a8e-4928-aa15-07db6af84325", "Sosyal medya sizi tanımlamasına izin vermeyin, siz kendi hikayenizi yazın.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(749), null },
                    { "e949ec38-e151-4f5c-a125-0ef512926ebf", "Sosyal medyadan uzaklaştığınızda, gerçek bağlantılar kurabileceğiniz anlar bulacaksınız.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(602), null },
                    { "efe31465-5895-4f26-a230-63eb3ea84e45", "Geri çekilin ve etrafınızdaki güzellikleri fark edin, en güzel manzaralar ekran değil, gerçek hayattadır.", new DateTime(2024, 4, 1, 15, 7, 46, 887, DateTimeKind.Local).AddTicks(777), null }
                });
        }
    }
}
