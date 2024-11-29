using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apisemana12.Migrations
{
    /// <inheritdoc />
    public partial class v2createactivefield : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Products");
        }
    }
}
