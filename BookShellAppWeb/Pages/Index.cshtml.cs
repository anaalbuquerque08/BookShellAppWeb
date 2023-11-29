using BookShellAppWeb.Models;
using BookShellAppWeb.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookShellAppWeb.Pages;

public class IndexModel : PageModel
{
    private ILivroService _service;
    public IndexModel(ILivroService service)
    {
        _service = service;
    }
    public IList<Livros> ListaLivros { get; private set; }

    public void OnGet()
    {
        ViewData["title"] = "Home Page";
        ListaLivros = _service.ObterTodos();
    }
}