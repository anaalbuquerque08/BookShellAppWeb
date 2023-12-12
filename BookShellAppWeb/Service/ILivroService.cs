using BookShellAppWeb.Models;

namespace BookShellAppWeb.Service;

public interface ILivroService
{

	IList<Livros> ObterTodos();
	Livros Obter(int id);
	void Incluir(Livros livros);
	void Alterar(Livros livros);
	void Excluir(int id);
	IList<Marca> ObterTodasMarcas();
	Marca ObterMarca(int id);
}
