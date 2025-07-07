using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class add_carfeature_IsUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarID_FeatureID",
                table: "CarFeatures",
                columns: new[] { "CarID", "FeatureID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarFeatures_CarID_FeatureID",
                table: "CarFeatures");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures",
                column: "CarID");
        }
    }
}
