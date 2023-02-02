using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppAmalt.Migrations
{
    public partial class Add_Relation_Education : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Portraits");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Portraits",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    University = table.Column<int>(nullable: false),
                    Work = table.Column<int>(nullable: false),
                    School = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Fractions_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    Married = table.Column<int>(nullable: false),
                    NotMarried = table.Column<int>(nullable: false),
                    HaveFriend = table.Column<int>(nullable: false),
                    CivilMerriage = table.Column<int>(nullable: false),
                    Engagement = table.Column<int>(nullable: false),
                    ActiveResearch = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relations_Fractions_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fractions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portraits_CityId",
                table: "Portraits",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PartyId",
                table: "Educations",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Relations_PartyId",
                table: "Relations",
                column: "PartyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portraits_Cities_CityId",
                table: "Portraits",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portraits_Cities_CityId",
                table: "Portraits");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Relations");

            migrationBuilder.DropIndex(
                name: "IX_Portraits_CityId",
                table: "Portraits");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Portraits");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Portraits",
                type: "text",
                nullable: true);
        }
    }
}
