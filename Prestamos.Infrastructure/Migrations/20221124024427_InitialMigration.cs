using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prestamos.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrestamoEncabezados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioBibliotecario = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestamoEncabezados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrestamoDetalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdLibro = table.Column<int>(type: "int", nullable: false),
                    IdPrestamoEncabezado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestamoDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrestamoDetalles_PrestamoEncabezados_IdPrestamoEncabezado",
                        column: x => x.IdPrestamoEncabezado,
                        principalTable: "PrestamoEncabezados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrestamoDetalles_IdPrestamoEncabezado",
                table: "PrestamoDetalles",
                column: "IdPrestamoEncabezado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrestamoDetalles");

            migrationBuilder.DropTable(
                name: "PrestamoEncabezados");
        }
    }
}
