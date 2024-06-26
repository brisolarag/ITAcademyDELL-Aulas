using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_26._06.Models.Tarefas;
using Microsoft.EntityFrameworkCore;

namespace aula_26._06.Context;
public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; set; } = null!;   // truque para o compilador  


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tarefa>()
            .ToTable("tarefas");
    }
}