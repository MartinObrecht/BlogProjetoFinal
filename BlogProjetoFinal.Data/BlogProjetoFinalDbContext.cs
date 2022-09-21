﻿using BlogProjetoFinal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogProjetoFinal.Data
{
    public class BlogProjetoFinalDbContext : DbContext
    {
        public BlogProjetoFinalDbContext() : base() { }
        public BlogProjetoFinalDbContext(DbContextOptions<BlogProjetoFinalDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        public DbSet<ArtigoEntity> ArtigoEntity { get; set; }
        public DbSet<CategoriaEntity> CategoriaEntity { get; set; }
        public DbSet<UsuarioEntity> UsuarioEntity { get; set; }
    }
}