using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WindowsForms.Migrations
{
    /// <inheritdoc />
    public partial class InicioProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
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
                    table.PrimaryKey("PK_Paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    _id = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    portada = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calificacion = table.Column<double>(type: "double", nullable: false),
                    Eliminado = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Eliminado", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Argentina" },
                    { 2, false, "Brasil" },
                    { 3, false, "Estados Unidos" },
                    { 4, false, "España" },
                    { 5, false, "Francia" },
                    { 6, false, "Italia" },
                    { 7, false, "Alemania" },
                    { 8, false, "México" },
                    { 9, false, "Reino Unido" },
                    { 10, false, "Japón" }
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "id", "Eliminado", "_id", "calificacion", "duracion", "portada", "titulo" },
                values: new object[,]
                {
                    { 1, false, null, 8.1999999999999993, 129, "https://upload.wikimedia.org/wikipedia/en/6/6a/El_secreto_de_sus_ojos_poster.jpg", "El secreto de sus ojos" },
                    { 2, false, null, 8.5999999999999996, 130, "https://upload.wikimedia.org/wikipedia/en/1/10/CidadedeDeus.jpg", "Ciudad de Dios" },
                    { 3, false, null, 8.0999999999999996, 122, "https://upload.wikimedia.org/wikipedia/en/7/7c/Relatos_Salvajes_poster.jpg", "Relatos salvajes" },
                    { 4, false, null, 8.0999999999999996, 154, "https://upload.wikimedia.org/wikipedia/en/6/6d/Amores_perros_poster.jpg", "Amores perros" },
                    { 5, false, null, 8.5999999999999996, 116, "https://upload.wikimedia.org/wikipedia/en/7/7c/Vitaebella.jpg", "La vida es bella" },
                    { 6, false, null, 8.1999999999999993, 118, "https://upload.wikimedia.org/wikipedia/en/6/67/Pans_labyrinth.jpg", "El laberinto del fauno" },
                    { 7, false, null, 8.8000000000000007, 142, "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", "Forrest Gump" },
                    { 8, false, null, 8.5, 132, "https://upload.wikimedia.org/wikipedia/en/5/53/Parasite_%282019_film%29.png", "Parásitos" },
                    { 9, false, null, 8.5999999999999996, 125, "https://upload.wikimedia.org/wikipedia/en/3/30/Spirited_Away_poster.JPG", "El viaje de Chihiro" },
                    { 10, false, null, 8.5, 155, "https://upload.wikimedia.org/wikipedia/en/8/88/CinemaParadiso.jpg", "Cinema Paradiso" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Peliculas");
        }
    }
}
