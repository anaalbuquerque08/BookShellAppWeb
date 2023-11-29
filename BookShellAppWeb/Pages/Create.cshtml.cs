using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookShellAppWeb.Pages
{
    public class CreateModel : PageModel
    {
        private ILivroService _service;

        public CreateModel(ILivroService service)
        {
            _service = service;
        }
        [BindProperty]
        public Livros Livros { get; set;}
        public IActionResult OnPost()
        {

            if ( !ModelState.IsValid)
            {
                return Page();
            }
            //inclusão 
            _service.Incluir(Livros);

            return RedirectToPage("/Index" );
        }
    }
}

