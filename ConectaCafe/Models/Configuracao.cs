using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace ConectaCafe.Models;

[Table("Configuração")]
public class Configuracao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(200, ErrorMessage = "A Configuração deve possuir, no máximo, 200 caracteres")]
    public string Horario { get; set; }

    [StringLength(20, ErrorMessage = "O telefone deve possuir, no máximo, 20 caracteres")]
    public string Telefone { get; set; }
}

