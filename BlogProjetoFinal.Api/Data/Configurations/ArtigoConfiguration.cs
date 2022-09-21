using BlogProjetoFinal.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProjetoFinal.Api.Data.Configurations
{
    public class ArtigoConfiguration : IEntityTypeConfiguration<Artigo>
    {
        public void Configure(EntityTypeBuilder<Artigo> builder)
        {
            builder.ToTable("tb_artigo");

            builder.Property(o => o.Id).ValueGeneratedNever();

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Titulo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(o => o.Conteudo)
                .HasColumnType("varchar(5000)")
                .IsRequired();

            builder.Property(o => o.DataCriacao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(o => o.DataAtualizacao)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
