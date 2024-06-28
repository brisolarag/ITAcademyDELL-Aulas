using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using projeto_api_ef.Models.Compromissos;

namespace projeto_api_ef.Models.Categorias;
public class Categoria
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = null!;
    public List<Compromisso> Compromissos { get; set; } = new();
}