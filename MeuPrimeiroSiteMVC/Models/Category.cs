/*
 * Com o Entity Framework (ORM), não criamos tabela direto no banco de dados
 * criamos um modelo/classe no projeto e o Entity Framework cria a tabela automaticamente.
 */

using System.ComponentModel.DataAnnotations;

namespace MeuPrimeiroSiteMVC.Models
{
    public class Category // classe
    {
        // propriedades
        [Key] // Data Annotattions - informa que o dado é chave primária
        public int Id { get; set; } // se o nome for Id ou ClasseId, automaticamente será chave primária
        [Required] // informa que o campo é requerido, não pode ser nulo - not null
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
