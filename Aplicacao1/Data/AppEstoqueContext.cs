using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Aplicacao1.Data
{
    public class AppEstoqueContext : DbContext
    {
        public AppEstoqueContext() : base("ControleEstoque")
        {
            
        }

        // declara as classes que darão origem à tabelas no banco
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
