using BookShellAppWeb.Data;
using BookShellAppWeb.Models;

namespace BookShellAppWeb.Service.Data;

public class LivroService : ILivroService
{
	private LivrariaDbContext _context;

	public LivroService(LivrariaDbContext context)
	{
		_context = context;
	}
	public void Alterar(Livros livros)
	{
		var livroEncontrado = Obter(livros.LivrosId);
		livroEncontrado.Nome = livros.Nome;
		livroEncontrado.Descricao = livros.Descricao;
		livroEncontrado.Valor = livros.Valor;
		livroEncontrado.ImagemUri = livros.ImagemUri;
		livroEncontrado.EntregaExpressa = livros.EntregaExpressa;
		livroEncontrado.DataCadastro = livros.DataCadastro;
		livroEncontrado.MarcaId = livros.MarcaId;
		_context.SaveChanges();
	}

	public void Excluir(int id)
	{
		var livroEncontrado = Obter(id);
		_context.Livros.Remove(livroEncontrado);
		_context.SaveChanges();
	}

	public void Incluir(Livros livros)
	{
		_context.Livros.Add(livros);
		_context.SaveChanges();
	}

	public Livros Obter(int id)
	{
		return _context.Livros.SingleOrDefault(item => item.LivrosId == id);
	}

	public IList<Livros> ObterTodos()
	{
		return _context.Livros.ToList();
	}

	public IList<Marca> ObterTodasMarcas()
		=> _context.Marca.ToList();

	public Marca ObterMarca(int id)
		=> _context.Marca.SingleOrDefault(item => item.MarcaId == id);
}
