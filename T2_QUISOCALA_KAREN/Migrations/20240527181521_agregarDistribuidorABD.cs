using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T2_QUISOCALA_KAREN.Migrations
{
    /// <inheritdoc />
    public partial class agregarDistribuidorABD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnioInicioOperacion",
                table: "Distribuidor",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnioInicioOperacion",
                table: "Distribuidor");
        }
    }
}
