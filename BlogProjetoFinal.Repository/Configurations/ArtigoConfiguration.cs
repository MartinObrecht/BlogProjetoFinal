using BlogProjetoFinal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProjetoFinal.Repository.Configurations
{
    public class ArtigoConfiguration : IEntityTypeConfiguration<ArtigoEntity>
    {
        public void Configure(EntityTypeBuilder<ArtigoEntity> builder)
        {
            builder.Property(o => o.Id).ValueGeneratedOnAdd();

            builder.HasKey(o => o.Id);
        }
    }
}
