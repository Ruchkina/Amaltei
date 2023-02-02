using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAmalt.Migrations
{
    public partial class Upp_City : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ValueCitis_CityId",
                table: "ValueCitis");

            migrationBuilder.CreateIndex(
                name: "IX_ValueCitis_CityId",
                table: "ValueCitis",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ValueCitis_CityId",
                table: "ValueCitis");

            migrationBuilder.CreateIndex(
                name: "IX_ValueCitis_CityId",
                table: "ValueCitis",
                column: "CityId",
                unique: true);
        }
    }
}
