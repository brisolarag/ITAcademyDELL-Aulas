using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_api_ef.Migrations
{
    public partial class renamedToCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compromissos_Cateogorias_CategoriaId",
                table: "Compromissos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cateogorias",
                table: "Cateogorias");

            migrationBuilder.RenameTable(
                name: "Cateogorias",
                newName: "Categorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compromissos_Categorias_CategoriaId",
                table: "Compromissos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compromissos_Categorias_CategoriaId",
                table: "Compromissos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorias",
                table: "Categorias");

            migrationBuilder.RenameTable(
                name: "Categorias",
                newName: "Cateogorias");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cateogorias",
                table: "Cateogorias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compromissos_Cateogorias_CategoriaId",
                table: "Compromissos",
                column: "CategoriaId",
                principalTable: "Cateogorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
