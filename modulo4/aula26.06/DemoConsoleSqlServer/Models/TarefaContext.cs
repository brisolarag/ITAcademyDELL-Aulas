using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoConsoleSqlServer.Models;
public class TarefaContext : DbContext
{
     public DbSet<Tarefa> Tarefas { get; set; } = null!;
}