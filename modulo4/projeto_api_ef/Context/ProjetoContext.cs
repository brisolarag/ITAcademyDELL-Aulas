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
            optionsBuilder.UseSqlServer(@"Server=win-brisolara;Database=itacademy_m4_projetoEF;Trusted_Connection=True");
            optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
        }
    }
}