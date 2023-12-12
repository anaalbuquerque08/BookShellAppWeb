using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShellAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoLivroMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Livros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_MarcaId",
                table: "Livros",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Marca_MarcaId",
                table: "Livros",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Marca_MarcaId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_MarcaId",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Livros");
        }
    }
}
