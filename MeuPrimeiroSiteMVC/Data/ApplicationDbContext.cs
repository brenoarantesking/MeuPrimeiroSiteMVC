﻿/*
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

        public DbSet<Category> Categories { get; set; } // DbSet<classe> nome_tabela - cria uma tabelas no banco de dados com o nome Categories


    }
}
