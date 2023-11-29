using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace BookShellAppWeb.Pages
{
    public class DetalhesModel : PageModel
    {
        private ILivroService _service;
        public DetalhesModel(ILivroService service)
        {
            _service = service;
        }
        public Livros Livros { get; private set; }
        public IActionResult OnGet(int id)
        {
            Livros = _service.Obter(id);

            if (Livros == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

