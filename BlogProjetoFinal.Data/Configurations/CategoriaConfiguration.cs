using BlogProjetoFinal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProjetoFinal.Data.Configurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<CategoriaEntity>
    {
        public void Configure(EntityTypeBuilder<CategoriaEntity> builder)
        {
            builder.ToTable("tb_categoria");

            builder.Property(o => o.ID).ValueGeneratedNever();

            builder.HasKey(o => o.ID);

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
                new CategoriaEntity { ID = 1, NomeCategoria = "Backend", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new CategoriaEntity { ID = 2, NomeCategoria = "Frontend", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new CategoriaEntity { ID = 3, NomeCategoria = "Mobile", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new CategoriaEntity { ID = 4, NomeCategoria = "Cloud", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new CategoriaEntity { ID = 5, NomeCategoria = "Testes", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now },
                new CategoriaEntity { ID = 6, NomeCategoria = "Arquitetura", DataCriacao = DateTime.Now, DataAtualizacao = DateTime.Now }
                );
        }
    }
}
