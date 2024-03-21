using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addeduserroleasseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfdcef50-80e8-48b1-8df1-ba1cd2231ef3", "df537b65-cbc8-4479-81e2-fc806dcd9059", "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cfdcef50-80e8-48b1-8df1-ba1cd2231ef3");
        }
    }
}
