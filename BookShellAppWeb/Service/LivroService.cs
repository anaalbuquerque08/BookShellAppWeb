using BookShellAppWeb.Models;

namespace BookShellAppWeb.Service;

	public class LivroService: ILivroService
	{
	public LivroService()
		=> CarregarListaInicial();

	private IList<Livros> _livros;

	private void CarregarListaInicial()
	{
	_livros = new List<Livros>()
	{
		new Livros
		{
			LivrosId =1,
			Nome = "Spanich Short Story",
			Descricao ="BookShell Ediction 2023 - JAN",
			ImagemUri = "/imagens/livro1.jpg",
			Valor = 59.99,
			EntregaExpressa = true,
			DataCadastro = DateTime.Now
},

		 new Livros
		{
			LivrosId =2,
			Nome = "Japonese Short Story  ",
			Descricao ="BookShell Ediction 2023 - FEV",
			ImagemUri = "/imagens/livro2.jpg",
			Valor = 49.99,
			EntregaExpressa = true,
			DataCadastro = DateTime.Now
		},
		  new Livros
		  {
			  LivrosId = 3,
			  Nome = "The Paper Palace  ",
			  Descricao = "BookShell Ediction 2023 - MAR",
			  ImagemUri = "/imagens/livro3.jpg",
			  Valor = 59.99,
			  EntregaExpressa = true,
			  DataCadastro = DateTime.Now
		  },
		   new Livros
		   {
			   LivrosId = 4,
			   Nome = "Conversation on Love",
			   Descricao = "BookShell Ediction 2023 - ABR",
			   ImagemUri = "/imagens/livro4.jpg",
			   Valor = 49.99,
			   EntregaExpressa = true,
			   DataCadastro = DateTime.Now
		   },
			new Livros
			{
				LivrosId = 5,
				Nome = "Lonely Castle in the Mirror",
				Descricao = "BookShell Ediction 2023 - MAI",
				ImagemUri = "/imagens/livro5.jpg",
				Valor = 59.99,
				EntregaExpressa = true,
				DataCadastro = DateTime.Now
			}

	};
	}
	

		public IList<Livros> ObterTodos()
		=> _livros;

		public Livros Obter(int id)
		=> ObterTodos().SingleOrDefault(item => item.LivrosId == id);

    public void Incluir(Livros livros)
	{
		var proximoId = _livros.Max(item => item.LivrosId) + 1;
		livros.LivrosId = proximoId;
		_livros.Add(livros);
	}
	 public void Alterar(Livros livros)
	{
		var livroEncontrado = _livros.SingleOrDefault(item => item.LivrosId == livros.LivrosId);
		livroEncontrado.Nome = livros.Nome;
		livroEncontrado.Descricao = livros.Descricao;
		livroEncontrado.Valor = livros.Valor;
		livroEncontrado.EntregaExpressa = livros.EntregaExpressa;
		livroEncontrado.DataCadastro = livros.DataCadastro;
		livroEncontrado.ImagemUri = livros.ImagemUri;
	}

	public void Excluir(int id)
	{
		var livroEncontrado = Obter(id);
		_livros.Remove(livroEncontrado);
	}
	}

	

