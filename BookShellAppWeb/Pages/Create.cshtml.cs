using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShellAppWeb.Pages
{
	[Authorize]
	public class CreateModel : PageModel
	{
		public SelectList MarcaOptionItems { get; set; }
		private ILivroService _service;

		public CreateModel(ILivroService service)
		{
			_service = service;
		}

		public void OnGet()
		{
			MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
			nameof(Marca.MarcaId),
			nameof(Marca.Descricao));
		}

		[BindProperty]
		public Livros Livros { get; set; }
		public IActionResult OnPost()
		{

			if (!ModelState.IsValid)
			{
				return Page();
			}
			//inclusão 
			_service.Incluir(Livros);

			TempData["TempMensagemSucesso"] = true;
			return RedirectToPage("/Index");
		}
	}
}

