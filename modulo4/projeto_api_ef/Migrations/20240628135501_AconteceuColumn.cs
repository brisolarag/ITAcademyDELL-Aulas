using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_api_ef.Migrations
{
    public partial class AconteceuColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "JaAconteceu",
                table: "Compromissos",
                newName: "Aconteceu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Aconteceu",
                table: "Compromissos",
                newName: "JaAconteceu");
        }
    }
}
