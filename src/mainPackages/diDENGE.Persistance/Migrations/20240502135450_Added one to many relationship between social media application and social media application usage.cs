using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace diDENGE.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Addedonetomanyrelationshipbetweensocialmediaapplicationandsocialmediaapplicationusage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMediaApplicationUsages_SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages",
                column: "SocialMediaApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMediaApplicationUsages_SocialMediaApplications_SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages",
                column: "SocialMediaApplicationId",
                principalTable: "SocialMediaApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMediaApplicationUsages_SocialMediaApplications_SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages");

            migrationBuilder.DropIndex(
                name: "IX_SocialMediaApplicationUsages_SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages");

            migrationBuilder.DropColumn(
                name: "SocialMediaApplicationId",
                table: "SocialMediaApplicationUsages");
        }
    }
}
