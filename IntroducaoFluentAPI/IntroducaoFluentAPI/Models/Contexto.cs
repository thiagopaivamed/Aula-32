using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroducaoFluentAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().HasKey(x => x.PessoaId);

            modelBuilder.Entity<Pessoa>().Property(x => x.Nome).HasColumnName("Nome").HasColumnType("ntext").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Pessoa>().Property(x => x.Idade).HasColumnName("Idade").HasColumnType("int").IsRequired(false);

            modelBuilder.Entity<Pessoa>().Property(x => x.Peso).HasColumnName("Peso").HasColumnType("float").IsRequired(false);

            modelBuilder.Entity<Pessoa>().ToTable("Pessoas");
        }
    }
}
