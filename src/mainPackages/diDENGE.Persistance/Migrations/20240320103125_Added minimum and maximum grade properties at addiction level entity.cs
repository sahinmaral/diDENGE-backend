using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedminimumandmaximumgradepropertiesataddictionlevelentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0d1d7927-5424-424c-a82e-428a1557786e");

            migrationBuilder.AddColumn<double>(
                name: "MaximumGrade",
                table: "AddictionLevels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinimumGrade",
                table: "AddictionLevels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                columns: new[] { "CreatedAt", "MaximumGrade", "MinimumGrade" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5247), 205.0, 173.0 });

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                columns: new[] { "CreatedAt", "MaximumGrade", "MinimumGrade" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5204), 139.0, 107.0 });

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                columns: new[] { "CreatedAt", "MaximumGrade", "MinimumGrade" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5185), 106.0, 74.0 });

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                columns: new[] { "CreatedAt", "MaximumGrade", "MinimumGrade" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5129), 73.0, 41.0 });

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                columns: new[] { "CreatedAt", "MaximumGrade", "MinimumGrade" },
                values: new object[] { new DateTime(2024, 3, 20, 13, 31, 25, 139, DateTimeKind.Local).AddTicks(5228), 172.0, 140.0 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e073fad-93d8-4b9d-82eb-8ce5ecf1df05", "1c30454b-45c4-4d3a-8644-87c137c68a9f", "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "4e073fad-93d8-4b9d-82eb-8ce5ecf1df05");

            migrationBuilder.DropColumn(
                name: "MaximumGrade",
                table: "AddictionLevels");

            migrationBuilder.DropColumn(
                name: "MinimumGrade",
                table: "AddictionLevels");

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "16cbcf23-aff3-4aca-a1f3-01ddc4b79699",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "4ac95367-eda8-49f2-9894-27421cbe256f",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "610ce001-62a1-40bb-8edb-886959be71f1",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "95cec253-2a7e-4466-b7e2-8aef25c437f6",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "AddictionLevels",
                keyColumn: "Id",
                keyValue: "f4b20091-1884-470a-8f05-6b25eba12a42",
                column: "CreatedAt",
                value: new DateTime(2024, 3, 19, 12, 58, 26, 116, DateTimeKind.Local).AddTicks(7511));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0d1d7927-5424-424c-a82e-428a1557786e", "8dd0a05f-dce7-4a79-8927-4723e51e98d6", "User", "USER" });
        }
    }
}
