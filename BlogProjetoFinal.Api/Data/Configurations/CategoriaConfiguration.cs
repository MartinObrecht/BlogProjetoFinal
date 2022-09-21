using BlogProjetoFinal.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProjetoFinal.Api.Data.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("tb_categoria");

            builder.Property(o => o.Id).ValueGeneratedNever();

            builder.HasKey(o => o.Id);

            builder.Property(o => o.NomeCategoria)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(o => o.DataCriacao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(o => o.DataAtualizacao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasData(
                new Categoria { Id = 1, NomeCategoria = "Backend", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new Categoria { Id = 2, NomeCategoria = "Frontend", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new Categoria { Id = 3, NomeCategoria = "Mobile", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new Categoria { Id = 4, NomeCategoria = "Cloud", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new Categoria { Id = 5, NomeCategoria = "Testes", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new Categoria { Id = 6, NomeCategoria = "Arquitetura", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now }
                );
        }
    }
}
