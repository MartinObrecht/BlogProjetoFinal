using BlogProjetoFinal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjetoFinal.Repository.Configurations
{
    public class ArtigoConfiguration : IEntityTypeConfiguration<ArtigoEntity>
    {
        public void Configure(EntityTypeBuilder<ArtigoEntity> builder)
        {
            builder.ToTable("tb_artigo");

            builder.Property(o => o.Id).ValueGeneratedOnAdd();

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
