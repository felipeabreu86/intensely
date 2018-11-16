using Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        /// <summary>
        ///     Sobrescrevendo o método OnModelCreating para remover a pluralização 
        ///     automática do Entity Framework e associar explicitamente as Entidades
        ///     às tabelas relacionadas.
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuario>().ToTable("USUARIOS");
        }
    }
}