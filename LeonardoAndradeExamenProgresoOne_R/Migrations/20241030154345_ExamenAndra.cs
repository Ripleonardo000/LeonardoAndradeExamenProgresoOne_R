using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeonardoAndradeExamenProgresoOne_R.Migrations
{
    /// <inheritdoc />
    public partial class ExamenAndra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Andrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    sueldo = table.Column<float>(type: "real", nullable: false),
                    empleo = table.Column<bool>(type: "bit", nullable: false),
                    Cumple = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Celulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    precio = table.Column<float>(type: "real", nullable: false),
                    año = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celulars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Andrades");

            migrationBuilder.DropTable(
                name: "Celulars");
        }
    }
}
