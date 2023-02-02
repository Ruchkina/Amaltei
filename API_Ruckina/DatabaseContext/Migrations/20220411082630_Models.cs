using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppAmalt.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Fraction",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Age",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    Less20Age = table.Column<int>(nullable: false),
                    Between20_30Age = table.Column<int>(nullable: false),
                    Between30_40Age = table.Column<int>(nullable: false),
                    Between40_60Age = table.Column<int>(nullable: false),
                    Over60 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Age", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Age_Fraction_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Political",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    Communists = table.Column<int>(nullable: false),
                    Socialists = table.Column<int>(nullable: false),
                    Moderate = table.Column<int>(nullable: false),
                    Liberals = table.Column<int>(nullable: false),
                    Conservatives = table.Column<int>(nullable: false),
                    Indifferents = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Political", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Political_Fraction_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Portrait",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartyId = table.Column<int>(nullable: false),
                    Sex = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    LifeMain = table.Column<string>(nullable: true),
                    Relation = table.Column<string>(nullable: true),
                    Political = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portrait", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Portrait_Fraction_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fraction_CityId",
                table: "Fraction",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Age_PartyId",
                table: "Age",
                column: "PartyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Political_PartyId",
                table: "Political",
                column: "PartyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portrait_PartyId",
                table: "Portrait",
                column: "PartyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fraction_City_CityId",
                table: "Fraction",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fraction_City_CityId",
                table: "Fraction");

            migrationBuilder.DropTable(
                name: "Age");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Political");

            migrationBuilder.DropTable(
                name: "Portrait");

            migrationBuilder.DropIndex(
                name: "IX_Fraction_CityId",
                table: "Fraction");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Fraction");
        }
    }
}
