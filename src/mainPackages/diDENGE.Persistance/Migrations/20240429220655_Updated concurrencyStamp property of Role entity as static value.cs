using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedconcurrencyStamppropertyofRoleentityasstaticvalue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f867519-977e-46da-87b7-eca5a30d7d0c",
                column: "ConcurrencyStamp",
                value: "c24248ef-e6a7-4ed5-be0f-5335e5cc6774");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f867519-977e-46da-87b7-eca5a30d7d0c",
                column: "ConcurrencyStamp",
                value: "02189894-f51a-4ad2-8e78-d4b7f240600c");
        }
    }
}
