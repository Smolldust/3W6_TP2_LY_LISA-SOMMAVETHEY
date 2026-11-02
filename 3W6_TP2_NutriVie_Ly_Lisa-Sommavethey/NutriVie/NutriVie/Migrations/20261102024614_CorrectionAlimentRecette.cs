using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriVie.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionAlimentRecette : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recettes_Aliments_AlimentId",
                table: "Recettes");

            migrationBuilder.DropIndex(
                name: "IX_Recettes_AlimentId",
                table: "Recettes");

            migrationBuilder.DropColumn(
                name: "AlimentId",
                table: "Recettes");

            migrationBuilder.CreateTable(
                name: "AlimentRecette",
                columns: table => new
                {
                    AlimentsId = table.Column<int>(type: "int", nullable: false),
                    RecettesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlimentRecette", x => new { x.AlimentsId, x.RecettesId });
                    table.ForeignKey(
                        name: "FK_AlimentRecette_Aliments_AlimentsId",
                        column: x => x.AlimentsId,
                        principalTable: "Aliments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlimentRecette_Recettes_RecettesId",
                        column: x => x.RecettesId,
                        principalTable: "Recettes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlimentRecette_RecettesId",
                table: "AlimentRecette",
                column: "RecettesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlimentRecette");

            migrationBuilder.AddColumn<int>(
                name: "AlimentId",
                table: "Recettes",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 1,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 2,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 3,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 4,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 5,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 6,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 7,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 8,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 9,
                column: "AlimentId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recettes",
                keyColumn: "Id",
                keyValue: 10,
                column: "AlimentId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Recettes_AlimentId",
                table: "Recettes",
                column: "AlimentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recettes_Aliments_AlimentId",
                table: "Recettes",
                column: "AlimentId",
                principalTable: "Aliments",
                principalColumn: "Id");
        }
    }
}
