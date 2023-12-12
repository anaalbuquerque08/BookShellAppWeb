using BookShellAppWeb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShellAppWeb.Data;

public class LivrariaDbContext : IdentityDbContext
{
	public DbSet<Livros> Livros { get; set; }
	public DbSet<Marca> Marca { get; set; }
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
   var config = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json")
	.Build();

		var stringConn = config.GetConnectionString("StringConn");
		optionsBuilder.UseSqlServer(stringConn);

	}
}

