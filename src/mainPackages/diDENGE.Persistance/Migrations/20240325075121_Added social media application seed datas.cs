using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedsocialmediaapplicationseeddatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4e073fad-93d8-4b9d-82eb-8ce5ecf1df05");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e073fad-93d8-4b9d-82eb-8ce5ecf1df05", "1c30454b-45c4-4d3a-8644-87c137c68a9f", "User", "USER" });
        }
    }
}
