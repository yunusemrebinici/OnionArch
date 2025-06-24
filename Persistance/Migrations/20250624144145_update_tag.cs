using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class update_tag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Tags_TagID",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_TagID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "TagID",
                table: "Blogs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_TagID",
                table: "Blogs",
                column: "TagID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Tags_TagID",
                table: "Blogs",
                column: "TagID",
                principalTable: "Tags",
                principalColumn: "TagID");
        }
    }
}
