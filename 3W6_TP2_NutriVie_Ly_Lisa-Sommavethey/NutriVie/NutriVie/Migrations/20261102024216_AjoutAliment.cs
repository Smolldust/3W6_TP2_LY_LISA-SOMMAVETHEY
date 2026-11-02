using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NutriVie.Migrations
{
    /// <inheritdoc />
    public partial class AjoutAliment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlimentId",
                table: "Recettes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Aliments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaloriesPour100g = table.Column<double>(type: "float", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aliments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aliments_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Aliments",
                columns: new[] { "Id", "CaloriesPour100g", "CategorieId", "Nom" },
                values: new object[,]
                {
                    { 1, 250.0, null, "Boeuf" },
                    { 2, 85.0, null, "Vin rouge" },
                    { 3, 41.0, null, "Carottes" },
                    { 4, 40.0, null, "Oignons" },
                    { 5, 541.0, null, "Bacon" },
                    { 6, 155.0, null, "Oeufs" },
                    { 7, 413.0, null, "Fromage gruyère" },
                    { 8, 292.0, null, "Crème fraîche" },
                    { 9, 165.0, null, "Poulet" },
                    { 10, 35.0, null, "Sauce tomate" },
                    { 11, 282.0, null, "Épices tikka" },
                    { 12, 61.0, null, "Yogourt" },
                    { 13, 717.0, null, "Beurre" },
                    { 14, 29.0, null, "Citron" },
                    { 15, 130.0, null, "Riz" },
                    { 16, 354.0, null, "Curcuma" },
                    { 17, 371.0, null, "Pâtes à lasagne" },
                    { 18, 254.0, null, "Viande hachée" },
                    { 19, 22.0, null, "Champignons" },
                    { 20, 8.0, null, "Bouillon de poulet" },
                    { 21, 360.0, null, "Semoule" },
                    { 22, 17.0, null, "Courgettes" },
                    { 23, 364.0, null, "Pois chiches" },
                    { 24, 275.0, null, "Pain pita" },
                    { 25, 595.0, null, "Tahini" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Aliments_CategorieId",
                table: "Aliments",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recettes_Aliments_AlimentId",
                table: "Recettes",
                column: "AlimentId",
                principalTable: "Aliments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recettes_Aliments_AlimentId",
                table: "Recettes");

            migrationBuilder.DropTable(
                name: "Aliments");

            migrationBuilder.DropIndex(
                name: "IX_Recettes_AlimentId",
                table: "Recettes");

            migrationBuilder.DropColumn(
                name: "AlimentId",
                table: "Recettes");
        }
    }
}
