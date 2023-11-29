using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookShellAppWeb.Pages
{
    public class Index1Model : PageModel
    {
		private ILivroService _service;

		public Index1Model(ILivroService service)
		{
			_service = service;
		}
		[BindProperty]
		public Livros Livros { get; set; }

		public IActionResult OnGet(int id)
		{
			Livros = _service.Obter(id);

			if (Livros == null)
			{
				return NotFound();
			}

			return Page();
		}
		public IActionResult OnPost()
		{

			if (!ModelState.IsValid)
			{
				return Page();
			}
			//alteração 
			_service.Alterar(Livros);

			return RedirectToPage("/Index");
		}

		public IActionResult OnPostExclusao()
		{
			//exclusão 
			_service.Excluir(Livros.LivrosId);

			return RedirectToPage("/Index");
		}

	}
}

