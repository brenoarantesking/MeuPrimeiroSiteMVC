/*
 * Configuração básica do Entity Framework
 */

using MeuPrimeiroSiteMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace MeuPrimeiroSiteMVC.Data
{
    public class ApplicationDbContext : DbContext // cria uma classe derivada de DbContext, que serve como ponto de entrada para interagir com o banco de dados.
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) // construtor
        {
            
        }

        // Mapeia qual <classe> para qual tabela do banco quando aplicado o Migrations
        public DbSet<Category> Categories { get; set; } // DbSet<classe> nome_tabela

        // Método utilizado para "popular" a tabela/entidade Category, sempre que atualizar o banco é ncessário uma Migration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );
        }

    }
}
