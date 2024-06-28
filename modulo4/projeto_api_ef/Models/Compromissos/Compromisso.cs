using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using projeto_api_ef.Models.Categorias;

namespace projeto_api_ef.Models.Compromissos;
public class Compromisso
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Titulo { get; set; } = null!;
    [MaxLength(255)]
    public string? Descricao { get; set; }
    public bool Aconteceu { get; set; } = false;
    public DateTime Data { get; set; } = DateTime.Now;
    public string? Link { get; set; }


    // relacionamentos:
    public Categoria Categoria { get; set; } = null!;
    public int CategoriaId { get; set; }

}