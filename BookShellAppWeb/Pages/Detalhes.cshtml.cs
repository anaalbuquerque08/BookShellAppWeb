using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace BookShellAppWeb.Pages
{
	public class DetalhesModel : PageModel
	{
		private ILivroService _service;
		public string DescricaoMarca { get; set; }

		public DetalhesModel(ILivroService service)
		{
			_service = service;
		}
		public Livros Livros { get; private set; }
		public IActionResult OnGet(int id)
		{
			Livros = _service.Obter(id);
			if (Livros.MarcaId is not null)
			{
				DescricaoMarca = _service.ObterMarca(Livros.MarcaId.Value).Descricao;

			}

			if (Livros == null)
			{
				return NotFound();
			}

			return Page();
		}
	}
}

