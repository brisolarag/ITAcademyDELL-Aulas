using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_26._06.Models.Tarefas;
public class Tarefa
{

    // só mapeia se for publica get; set;
    public long Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Descricao { get; set; }
    public bool Completa { get; set; }
}