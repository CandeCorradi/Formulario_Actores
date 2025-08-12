using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class actoresestudio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actores_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Estudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudios", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Actores",
                columns: new[] { "Id", "Eliminado", "Nombre", "PaisId" },
                values: new object[,]
                {
                    { 1, false, "Leonardo DiCaprio", 3 },
                    { 2, false, "Meryl Streep", 3 },
                    { 3, false, "Robert De Niro", 3 },
                    { 4, false, "Scarlett Johansson", 3 },
                    { 5, false, "Ricardo Darín", 1 }
                });

            migrationBuilder.InsertData(
                table: "Estudios",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Warner Bros." },
                    { 2, false, "Universal Pictures" },
                    { 3, false, "Paramount Pictures" },
                    { 4, false, "20th Century Fox" },
                    { 5, false, "Columbia Pictures" }
                });

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 1,
                column: "PaisId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 2,
                column: "PaisId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 3,
                column: "PaisId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 4,
                column: "PaisId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 5,
                column: "PaisId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 6,
                column: "PaisId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 7,
                column: "PaisId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 8,
                column: "PaisId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 9,
                column: "PaisId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 10,
                column: "PaisId",
                value: 7);

            migrationBuilder.CreateIndex(
                name: "IX_Actores_PaisId",
                table: "Actores",
                column: "PaisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actores");

            migrationBuilder.DropTable(
                name: "Estudios");

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 1,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 2,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 3,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 4,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 5,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 6,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 7,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 8,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 9,
                column: "PaisId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Peliculas",
                keyColumn: "id",
                keyValue: 10,
                column: "PaisId",
                value: null);
        }
    }
}
