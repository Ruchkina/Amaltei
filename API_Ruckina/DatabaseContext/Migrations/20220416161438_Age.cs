using Microsoft.EntityFrameworkCore.Migrations;

namespace AppAmalt.Migrations
{
    public partial class Age : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Age_Fraction_PartyId",
                table: "Age");

            migrationBuilder.DropForeignKey(
                name: "FK_Fraction_Cities_CityId",
                table: "Fraction");

            migrationBuilder.DropForeignKey(
                name: "FK_Gender_Fraction_PartyId",
                table: "Gender");

            migrationBuilder.DropForeignKey(
                name: "FK_LifeMain_Fraction_PartyId",
                table: "LifeMain");

            migrationBuilder.DropForeignKey(
                name: "FK_Political_Fraction_PartyId",
                table: "Political");

            migrationBuilder.DropForeignKey(
                name: "FK_Portrait_Fraction_PartyId",
                table: "Portrait");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCity_Cities_CityId",
                table: "ValueCity");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCity_Fraction_PartyId",
                table: "ValueCity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ValueCity",
                table: "ValueCity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portrait",
                table: "Portrait");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Political",
                table: "Political");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LifeMain",
                table: "LifeMain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fraction",
                table: "Fraction");

            migrationBuilder.RenameTable(
                name: "ValueCity",
                newName: "ValueCitis");

            migrationBuilder.RenameTable(
                name: "Portrait",
                newName: "Portraits");

            migrationBuilder.RenameTable(
                name: "Political",
                newName: "Politicals");

            migrationBuilder.RenameTable(
                name: "LifeMain",
                newName: "LifeMains");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "Genders");

            migrationBuilder.RenameTable(
                name: "Fraction",
                newName: "Fractions");

            migrationBuilder.RenameIndex(
                name: "IX_ValueCity_PartyId",
                table: "ValueCitis",
                newName: "IX_ValueCitis_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_ValueCity_CityId",
                table: "ValueCitis",
                newName: "IX_ValueCitis_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Portrait_PartyId",
                table: "Portraits",
                newName: "IX_Portraits_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Political_PartyId",
                table: "Politicals",
                newName: "IX_Politicals_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_LifeMain_PartyId",
                table: "LifeMains",
                newName: "IX_LifeMains_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Gender_PartyId",
                table: "Genders",
                newName: "IX_Genders_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Fraction_CityId",
                table: "Fractions",
                newName: "IX_Fractions_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ValueCitis",
                table: "ValueCitis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portraits",
                table: "Portraits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Politicals",
                table: "Politicals",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LifeMains",
                table: "LifeMains",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genders",
                table: "Genders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fractions",
                table: "Fractions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Age_Fractions_PartyId",
                table: "Age",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fractions_Cities_CityId",
                table: "Fractions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genders_Fractions_PartyId",
                table: "Genders",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LifeMains_Fractions_PartyId",
                table: "LifeMains",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Politicals_Fractions_PartyId",
                table: "Politicals",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portraits_Fractions_PartyId",
                table: "Portraits",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCitis_Cities_CityId",
                table: "ValueCitis",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCitis_Fractions_PartyId",
                table: "ValueCitis",
                column: "PartyId",
                principalTable: "Fractions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Age_Fractions_PartyId",
                table: "Age");

            migrationBuilder.DropForeignKey(
                name: "FK_Fractions_Cities_CityId",
                table: "Fractions");

            migrationBuilder.DropForeignKey(
                name: "FK_Genders_Fractions_PartyId",
                table: "Genders");

            migrationBuilder.DropForeignKey(
                name: "FK_LifeMains_Fractions_PartyId",
                table: "LifeMains");

            migrationBuilder.DropForeignKey(
                name: "FK_Politicals_Fractions_PartyId",
                table: "Politicals");

            migrationBuilder.DropForeignKey(
                name: "FK_Portraits_Fractions_PartyId",
                table: "Portraits");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCitis_Cities_CityId",
                table: "ValueCitis");

            migrationBuilder.DropForeignKey(
                name: "FK_ValueCitis_Fractions_PartyId",
                table: "ValueCitis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ValueCitis",
                table: "ValueCitis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portraits",
                table: "Portraits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Politicals",
                table: "Politicals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LifeMains",
                table: "LifeMains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genders",
                table: "Genders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fractions",
                table: "Fractions");

            migrationBuilder.RenameTable(
                name: "ValueCitis",
                newName: "ValueCity");

            migrationBuilder.RenameTable(
                name: "Portraits",
                newName: "Portrait");

            migrationBuilder.RenameTable(
                name: "Politicals",
                newName: "Political");

            migrationBuilder.RenameTable(
                name: "LifeMains",
                newName: "LifeMain");

            migrationBuilder.RenameTable(
                name: "Genders",
                newName: "Gender");

            migrationBuilder.RenameTable(
                name: "Fractions",
                newName: "Fraction");

            migrationBuilder.RenameIndex(
                name: "IX_ValueCitis_PartyId",
                table: "ValueCity",
                newName: "IX_ValueCity_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_ValueCitis_CityId",
                table: "ValueCity",
                newName: "IX_ValueCity_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Portraits_PartyId",
                table: "Portrait",
                newName: "IX_Portrait_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Politicals_PartyId",
                table: "Political",
                newName: "IX_Political_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_LifeMains_PartyId",
                table: "LifeMain",
                newName: "IX_LifeMain_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Genders_PartyId",
                table: "Gender",
                newName: "IX_Gender_PartyId");

            migrationBuilder.RenameIndex(
                name: "IX_Fractions_CityId",
                table: "Fraction",
                newName: "IX_Fraction_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ValueCity",
                table: "ValueCity",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portrait",
                table: "Portrait",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Political",
                table: "Political",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LifeMain",
                table: "LifeMain",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fraction",
                table: "Fraction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Age_Fraction_PartyId",
                table: "Age",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fraction_Cities_CityId",
                table: "Fraction",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gender_Fraction_PartyId",
                table: "Gender",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LifeMain_Fraction_PartyId",
                table: "LifeMain",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Political_Fraction_PartyId",
                table: "Political",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portrait_Fraction_PartyId",
                table: "Portrait",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCity_Cities_CityId",
                table: "ValueCity",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ValueCity_Fraction_PartyId",
                table: "ValueCity",
                column: "PartyId",
                principalTable: "Fraction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
