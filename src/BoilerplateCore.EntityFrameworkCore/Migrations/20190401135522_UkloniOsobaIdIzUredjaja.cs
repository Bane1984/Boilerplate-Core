using Microsoft.EntityFrameworkCore.Migrations;

namespace BoilerplateCore.Migrations
{
    public partial class UkloniOsobaIdIzUredjaja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OsobaId",
                table: "Uredjaji",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uredjaji_OsobaId",
                table: "Uredjaji",
                column: "OsobaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uredjaji_Osobe_OsobaId",
                table: "Uredjaji",
                column: "OsobaId",
                principalTable: "Osobe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uredjaji_Osobe_OsobaId",
                table: "Uredjaji");

            migrationBuilder.DropIndex(
                name: "IX_Uredjaji_OsobaId",
                table: "Uredjaji");

            migrationBuilder.DropColumn(
                name: "OsobaId",
                table: "Uredjaji");
        }
    }
}
