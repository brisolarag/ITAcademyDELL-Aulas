using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto_api_ef.Models.Categorias;
using projeto_api_ef.Models.Compromissos;

namespace projeto_api_ef.Context
{
    public class ProjetoContext : DbContext
    {
        public DbSet<Compromisso> Compromissos { get; set; } = null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // hide from GITHUB
            optionsBuilder.UseSqlServer(@"Server=SERVER;Database=DATABASE;Trusted_Connection=True");
            optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
        }
    }
}