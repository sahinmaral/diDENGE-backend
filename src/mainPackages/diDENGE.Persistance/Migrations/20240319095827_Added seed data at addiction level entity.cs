using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedseeddataataddictionlevelentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad5a1322-054f-4117-b960-5aafb23ab9bd");

            migrationBuilder.InsertData(
                table: "AddictionLevels",
                columns: new[] { "Id", "CreatedAt", "DailyLimit", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "16cbcf23-aff3-4aca-a1f3-01ddc4b79699", new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7562), 150.0, "Çok Yüksek Bağımlı", null },
                    { "4ac95367-eda8-49f2-9894-27421cbe256f", new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7464), 90.0, "Orta Bağımlı", null },
                    { "610ce001-62a1-40bb-8edb-886959be71f1", new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7406), 60.0, "Az Bağımlı", null },
                    { "95cec253-2a7e-4466-b7e2-8aef25c437f6", new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7309), 0.0, "Bağımlılık Yok", null },
                    { "f4b20091-1884-470a-8f05-6b25eba12a42", new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7511), 120.0, "Yüksek Bağımlı", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d1d7927-5424-424c-a82e-428a1557786e", "8dd0a05f-dce7-4a79-8927-4723e51e98d6", "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699");

            migrationBuilder.DeleteData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f");

            migrationBuilder.DeleteData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1");

            migrationBuilder.DeleteData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6");

            migrationBuilder.DeleteData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0d1d7927-5424-424c-a82e-428a1557786e");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad5a1322-054f-4117-b960-5aafb23ab9bd", "80b0c48d-2711-411c-a967-7d9310eed698", "User", "USER" });
        }
    }
}
