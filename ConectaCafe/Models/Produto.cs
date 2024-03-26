using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConectaCafe.Models;

[Table("Produto")] 
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe o nome!😡")]
    [StringLength(60, ErrorMessage = "O nome deve possuir, no máximo, 30 caracteres!⚠️")]
    public string Nome { get; set; }

    [Display(Name = "Descrição")]  
    [StringLength(200, ErrorMessage = "A descrição deve possuir, no máximo, 200 caracteres!⚠️")]
    public string Descricao { get; set; }
    
    [Display(Name = "Preço")] 
    [Required(ErrorMessage = "Por favor, informe o preço!😡😡😡")]
    public decimal Preco { get; set; }


    [StringLength(200)]
    public string Foto { get; set; }

    [Required(ErrorMessage = "Pooor geentileeza, INFORME A CATEGORIA ID!🥺🥺🙏🙏")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")] 

    public Categoria Categoria { get; set; }
}


