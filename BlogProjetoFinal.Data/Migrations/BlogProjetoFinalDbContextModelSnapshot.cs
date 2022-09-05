using BlogProjetoFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace BlogProjetoFinal.Migrations
{
    [DbContext(typeof(BlogProjetoFinalDbContext))]
    partial class BlogProjetoFinalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.ArtigoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Autor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("varchar(5000)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tb_artigo", (string)null);
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.CategoriaEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("tb_categoria", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3144),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3130),
                            NomeCategoria = "Backend"
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3146),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3146),
                            NomeCategoria = "Frontend"
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3147),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3147),
                            NomeCategoria = "Mobile"
                        },
                        new
                        {
                            Id = 4,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3149),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3148),
                            NomeCategoria = "Cloud"
                        },
                        new
                        {
                            Id = 5,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3150),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3149),
                            NomeCategoria = "Testes"
                        },
                        new
                        {
                            Id = 6,
                            DataAtualizacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3151),
                            DataCriacao = new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3150),
                            NomeCategoria = "Arquitetura"
                        });
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NomeDeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tb_usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
