using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class add_migration_carID_PricingID_unique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricings");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_CarID_PricingID",
                table: "CarPricings",
                columns: new[] { "CarID", "PricingID" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CarPricings_CarID_PricingID",
                table: "CarPricings");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricings",
                column: "CarID");
        }
    }
}
