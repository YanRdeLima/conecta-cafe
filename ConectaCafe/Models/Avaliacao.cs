using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace ConectaCafe.Models;

[Table("Avaliação")] 
public class Avaliacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)] 
    public int Id { get; set; }

    
    [Required(ErrorMessage = "Por favor, informe seu nome!😡")]
    [StringLength(60, ErrorMessage = "O nome deve possuir, no máximo, 60 caracteres!⚠️")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Por favor, dê um título à sua avaliação!😡")]
    [StringLength(100, ErrorMessage = "O nome deve possuir, no máximo, 100 caracteres!⚠️")]
    public string Título { get; set; }

    [Display(Name = "Avaliação")]  
    [StringLength(700, ErrorMessage = "A Avaliação deve possuir, no máximo, 700 caracteres!⚠️")]
    public string Avaliação { get; set; }

    [Required(ErrorMessage = "Por favor, não se esqueça de dar a sua nota!")]
    [Column(TypeName = "decimal(1,0)")]
    public decimal Nota { get; set; }

    [Display (Name = "Data da Avaliação")]
    [DataType(DataType.Date)]
    public DateTime DataAvaliação { get; set; }

}


