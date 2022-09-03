using BlogProjetoFinal.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProjetoFinal.Api.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("tb_usuario");

            builder.Property(o => o.Id).ValueGeneratedNever();

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(o => o.Email)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder.Property(o => o.NomeDeUsuario)
                .HasColumnType("nvarchar(20)")
                .IsRequired();

            builder.Property(o => o.Senha)
                .HasColumnType("nvarchar(50)")
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
