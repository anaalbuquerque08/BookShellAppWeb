using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookShellAppWeb.Pages
{
	[Authorize]
    public class EditModel : PageModel
    {
		private ILivroService _service;

		public EditModel(ILivroService service)
		{
			_service = service;
		}
		[BindProperty]
		public Livros Livros { get; set; }
		public SelectList MarcaOptionItems { get; private set; }

		public void OnGet(int id)
		{
			Livros = _service.Obter(id);

			MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
												nameof(Marca.MarcaId),
												nameof(Marca.Descricao));
		}

	
		public IActionResult OnPost()
		{

			if (!ModelState.IsValid)
			{
				return Page();
			}
			//alteração 
			_service.Alterar(Livros);

			TempData["TempMensagemSucesso"] = true;

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

