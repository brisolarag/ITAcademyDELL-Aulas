using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_api_ef.Controllers.Compromissos
{
    public record CompromissoDto (string titulo, string? descricao, string? dataString, string? link);
}

   //     public int Id { get; set; }

    // [Required]
    // [MaxLength(100)]
    // public string Titulo { get; set; } = null!;
    // [MaxLength(255)]
    // public string? Descricao { get; set; }
    // public bool JaAconteceu { get; set; } = false;
    // public DateTime Data { get; set; }
    // public string? Link { get; set; }


    // // relacionamentos:
    // public Categoria Categoria { get; set; } = null!;
    // public int CategoriaId { get; set; }