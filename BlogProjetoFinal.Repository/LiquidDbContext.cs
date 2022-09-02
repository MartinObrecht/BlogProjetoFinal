using BlogProjetoFinal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProjetoFinal.Repository
{
    public class LiquidDbContext : DbContext
    {
        public LiquidDbContext() : base() { }

        public LiquidDbContext(DbContextOptions<LiquidDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }

        public DbSet<UsuarioEntity> UsuarioEntity { get; set; }
        public DbSet<ArtigoEntity> ArtigoEntity { get; set; }
        public DbSet<CategoriaEntity> CategoriaEntity { get; set; }
    }
}
