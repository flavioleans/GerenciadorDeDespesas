using GerenciadorDespesas.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorDespesas.Models;

namespace GerenciadorDespesas.Models
{
    public class Contexto: DbContext
    {
        public DbSet<Meses> Meses { get; set; }
        public DbSet<Salarios> Salarios { get; set; }
        public DbSet<Meses> Despesas { get; set; }
        public DbSet<TipoDespesas> TipoDespesas { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes): base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoDespesasMap());
            modelBuilder.ApplyConfiguration(new DespesasMap());
            modelBuilder.ApplyConfiguration(new SalariosMap());
            modelBuilder.ApplyConfiguration(new MesesMap());
        }

        public DbSet<GerenciadorDespesas.Models.Despesas> Despesas_1 { get; set; }

    }
}
