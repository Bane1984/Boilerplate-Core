using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerplateCore.Migrations
{
    public partial class promjenaPrveMigracije : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Osobe");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Kancelarije");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Osobe",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Kancelarije",
                nullable: false,
                defaultValue: 0);
        }
    }
}
