using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppAmalt.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fraction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fraction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    WomenFollower = table.Column<int>(nullable: false),
                    MenFollower = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gender_Fraction_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LifeMain",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    Family = table.Column<int>(nullable: false),
                    CareerMoney = table.Column<int>(nullable: false),
                    FamePower = table.Column<int>(nullable: false),
                    Entertainment = table.Column<int>(nullable: false),
                    Science = table.Column<int>(nullable: false),
                    SelfDevelopment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeMain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LifeMain_Fraction_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gender_PartyId",
                table: "Gender",
                column: "PartyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LifeMain_PartyId",
                table: "LifeMain",
                column: "PartyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "LifeMain");

            migrationBuilder.DropTable(
                name: "Fraction");
        }
    }
}
