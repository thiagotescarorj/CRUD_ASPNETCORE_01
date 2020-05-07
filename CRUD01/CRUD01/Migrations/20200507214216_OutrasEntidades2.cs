using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD01.Migrations
{
    public partial class OutrasEntidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Vendedor",
                newName: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Vendedor",
                newName: "Name");
        }
    }
}
