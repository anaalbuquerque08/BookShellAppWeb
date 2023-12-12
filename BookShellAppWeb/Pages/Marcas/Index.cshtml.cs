using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookShellAppWeb.Data;
using BookShellAppWeb.Models;

namespace BookShellAppWeb.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly BookShellAppWeb.Data.LivrariaDbContext _context;

        public IndexModel(BookShellAppWeb.Data.LivrariaDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}
