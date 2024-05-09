using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class AddedisDoNotDistrubEnabledandexpirationdateofUserentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DoNotDisturbExpires",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDoNotDisturbEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoNotDisturbExpires",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDoNotDisturbEnabled",
                table: "Users");
        }
    }
}
