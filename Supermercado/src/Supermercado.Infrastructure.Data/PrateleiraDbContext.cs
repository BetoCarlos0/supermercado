using Supermercado.Domain;
using Microsoft.EntityFrameworkCore;

namespace Supermercado.Infrastructure.Data
{
    public class PrateleiraDbContext : DbContext
    {
        public PrateleiraDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PrateleiraDbContext).Assembly);
        }
    }
}
