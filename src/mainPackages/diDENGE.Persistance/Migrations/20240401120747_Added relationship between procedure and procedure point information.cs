using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedrelationshipbetweenprocedureandprocedurepointinformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ProcedureId",
                table: "ProcedurePointInformations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_ProcedurePointInformations_ProcedureId",
                table: "ProcedurePointInformations",
                column: "ProcedureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProcedurePointInformations_Procedures_ProcedureId",
                table: "ProcedurePointInformations",
                column: "ProcedureId",
                principalTable: "Procedures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProcedurePointInformations_Procedures_ProcedureId",
                table: "ProcedurePointInformations");

            migrationBuilder.DropIndex(
                name: "IX_ProcedurePointInformations_ProcedureId",
                table: "ProcedurePointInformations");

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

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "ProcedurePointInformations");

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
    }
}
