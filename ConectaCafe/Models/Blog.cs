using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace ConectaCafe.Models;

[Table("Blog")] 
public class Blog
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] 
    public int Id { get; set; }

    
    [Required(ErrorMessage = "Por favor, informe seu nome.")]
    [StringLength(60, ErrorMessage = "O nome deve possuir, no máximo, 60 caracteres!⚠️")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Por favor, dê um título ao seu artigo.")]
    [StringLength(100, ErrorMessage = "O título deve possuir, no máximo, 100 caracteres!⚠️")]
    public string Título { get; set; }

    [Display(Name = "Texto")]  
    [StringLength(700, ErrorMessage = "O seu texto deve possuir, no máximo, 1000 caracteres!⚠️")]
    public string Texto { get; set; }

    [Display (Name = "Data de Publicação")]
    [DataType(DataType.Date)]
    public DateTime DataPublicacao { get; set; }

    public ICollection<BlogTag> BlogTags { get; set; }

}


