namespace BookShellAppWeb.Models;

public class Marca
{
    public int MarcaId { get; set; }
    public string Descricao { get; set; }

    public ICollection<Livros>? LivrosCollec { get; set; }
}
