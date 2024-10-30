using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeonardoAndradeExamenProgresoOne_R.Migrations.LeonardoAndradeExamenProgresoOne_R
{
    /// <inheritdoc />
    public partial class ExamenLA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
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
                    table.PrimaryKey("PK_Celular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Andrade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    sueldo = table.Column<float>(type: "real", nullable: false),
                    empleo = table.Column<bool>(type: "bit", nullable: false),
                    Cumple = table.Column<int>(type: "int", nullable: false),
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Andrade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Andrade_Celular_IdCelular",
                        column: x => x.IdCelular,
                        principalTable: "Celular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Andrade_IdCelular",
                table: "Andrade",
                column: "IdCelular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Andrade");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
