using BlogProjetoFinal.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProjetoFinal.Api.Data
{
    public class BlogProjetoFinalDbContext : DbContext
    {
        public BlogProjetoFinalDbContext() : base() { }
        public BlogProjetoFinalDbContext(DbContextOptions<BlogProjetoFinalDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        public DbSet<Usuario> UsuarioEntity { get; set; }
        public DbSet<Artigo> ArtigoEntity { get; set; }
        public DbSet<Categoria> CategoriaEntity { get; set; }
    }
}