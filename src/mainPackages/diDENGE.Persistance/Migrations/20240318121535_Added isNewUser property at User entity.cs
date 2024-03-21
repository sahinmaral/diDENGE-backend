using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddedisNewUserpropertyatUserentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "cfdcef50-80e8-48b1-8df1-ba1cd2231ef3");

            migrationBuilder.AddColumn<bool>(
                name: "IsNewUser",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ad5a1322-054f-4117-b960-5aafb23ab9bd", "80b0c48d-2711-411c-a967-7d9310eed698", "User", "USER" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ad5a1322-054f-4117-b960-5aafb23ab9bd");

            migrationBuilder.DropColumn(
                name: "IsNewUser",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfdcef50-80e8-48b1-8df1-ba1cd2231ef3", "df537b65-cbc8-4479-81e2-fc806dcd9059", "User", "USER" });
        }
    }
}
