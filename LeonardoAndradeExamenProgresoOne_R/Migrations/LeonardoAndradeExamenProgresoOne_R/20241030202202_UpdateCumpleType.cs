using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeonardoAndradeExamenProgresoOne_R.Migrations.LeonardoAndradeExamenProgresoOne_R
{
    /// <inheritdoc />
    public partial class UpdateCumpleType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Cumple",
                table: "Andrade",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cumple",
                table: "Andrade",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
