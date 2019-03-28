using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerplateCore.Migrations
{
    public partial class idDodatPrekoKlaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UredjajUzetVracenId",
                table: "UredjajUzetVraceni",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UredjajId",
                table: "Uredjaji",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OsobaId",
                table: "Osobe",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "KancelarijaId",
                table: "Kancelarije",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UredjajUzetVraceni",
                newName: "UredjajUzetVracenId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Uredjaji",
                newName: "UredjajId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Osobe",
                newName: "OsobaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Kancelarije",
                newName: "KancelarijaId");
        }
    }
}
