using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAmalt.Migrations
{
    public partial class Up_City : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "ValueCitis",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "ValueCitis",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
