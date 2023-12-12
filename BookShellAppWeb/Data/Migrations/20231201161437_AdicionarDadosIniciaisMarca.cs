using BookShellAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShellAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            var context = new LivrariaDbContext();
            context.Marca.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicialMarca()
        {
            return new List<Marca>()
            {
                new Marca() {Descricao = "DarkSide"},
                new Marca() {Descricao = "Intrinsecos"},
                new Marca() {Descricao = "Galera Record"},
            };
        }
    }
}
