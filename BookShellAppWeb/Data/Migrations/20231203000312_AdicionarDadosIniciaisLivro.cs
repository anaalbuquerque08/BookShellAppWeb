using BookShellAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShellAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

			var context = new LivrariaDbContext();
			context.Livros.AddRange(ObterCargaInicialLivro());
			context.SaveChanges();
		}

		private IList<Livros> ObterCargaInicialLivro()
		{
			return new List<Livros>()
			{
				new Livros
				{
					Nome = "Spanich Short Story",
					Descricao ="BookShell Ediction 2023 - JAN",
					ImagemUri = "/imagens/livro1.jpg",
					Valor = 59.99,
					EntregaExpressa = true,
					DataCadastro = DateTime.Now
				},
				new Livros
				{
					Nome = "Japonese Short Story  ",
					Descricao ="BookShell Ediction 2023 - FEV",
					ImagemUri = "/imagens/livro2.jpg",
					Valor = 49.99,
					EntregaExpressa = true,
					DataCadastro = DateTime.Now
				},
				new Livros
				{
					Nome = "The Paper Palace  ",
					Descricao = "BookShell Ediction 2023 - MAR",
					ImagemUri = "/imagens/livro3.jpg",
					Valor = 59.99,
					EntregaExpressa = true,
					DataCadastro = DateTime.Now
				},
				new Livros
				{
					Nome = "Conversation on Love",
					Descricao = "BookShell Ediction 2023 - ABR",
					ImagemUri = "/imagens/livro4.jpg",
					Valor = 49.99,
					EntregaExpressa = true,
					DataCadastro = DateTime.Now
				},
				new Livros
				{
					Nome = "Lonely Castle in the Mirror",
					Descricao = "BookShell Ediction 2023 - MAI",
					ImagemUri = "/imagens/livro5.jpg",
					Valor = 59.99,
					EntregaExpressa = true,
					DataCadastro = DateTime.Now
				}
			};
		}
	}
}
