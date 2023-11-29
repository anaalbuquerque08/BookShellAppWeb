using System.ComponentModel.DataAnnotations;

namespace BookShellAppWeb.Models;

public class Livros
{

    public int LivrosId { get; set; }

    [Required(ErrorMessage ="Campo 'Nome' obrigatório.")]
    [StringLength(50, MinimumLength =2 , ErrorMessage ="O Campo 'Nome' tem que ter entre 2 á 50 caracteres." )]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

	[Required(ErrorMessage = "Campo 'Descrição' obrigatório.")]
	[Display(Name ="Descrição")]
    public string Descricao{ get; set; }
  
    [Required(ErrorMessage = "Campo 'Imagem' obrigatório.")]
    [Display(Name = "Caminho da Imagem URL")]
	public string ImagemUri { get; set;}


	[Required(ErrorMessage = "Campo 'Preço' obrigatório.")]
	[Display(Name = "Preço")]
    [DataType(DataType.Currency)]
    public double Valor { get; set; }
    

    
    [Display(Name = "Entrega Expressa")]
	public bool EntregaExpressa { get; set; }
    public string EntregaExpressaFormatada => EntregaExpressa ? "Sim":"Não";
   

    [Required(ErrorMessage = "Selecione o mês e o ano .")] 
    [Display(Name = "Disponível em")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }
}
