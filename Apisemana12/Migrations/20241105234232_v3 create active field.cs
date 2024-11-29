using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apisemana12.Migrations
{
    /// <inheritdoc />
    public partial class v3createactivefield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Products",
                newName: "Enabled");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "Products",
                newName: "Activo");
        }
    }
}
