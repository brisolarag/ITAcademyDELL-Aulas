using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using projeto_api_ef.Models.Compromissos;

namespace projeto_api_ef.Controllers.Categorias
{
    public record CategoriaResponseDto(int id, string nome, List<Compromisso> compromissos);
}