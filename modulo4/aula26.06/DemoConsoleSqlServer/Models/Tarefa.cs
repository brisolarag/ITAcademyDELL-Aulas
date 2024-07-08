using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoConsoleSqlServer.Models;
public class Tarefa
{
    public long Id { get; set; }
    public string Nome { get; set; } = null!;
    public bool Completa { get; set; }
}