﻿// <auto-generated />
using System;
using BlogProjetoFinal.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogProjetoFinal.Api.Migrations
{
    [DbContext(typeof(BlogProjetoFinalDbContext))]
    [Migration("20220921231200_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.ArtigoEntity", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaEntityID")
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

                    b.Property<Guid>("UsuarioEntityID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaEntityID");

                    b.HasIndex("UsuarioEntityID");

                    b.ToTable("tb_artigo", (string)null);
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.CategoriaEntity", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.ToTable("tb_categoria", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3146),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3137),
                            NomeCategoria = "Backend"
                        },
                        new
                        {
                            ID = 2,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3148),
                            NomeCategoria = "Frontend"
                        },
                        new
                        {
                            ID = 3,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3150),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149),
                            NomeCategoria = "Mobile"
                        },
                        new
                        {
                            ID = 4,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151),
                            NomeCategoria = "Cloud"
                        },
                        new
                        {
                            ID = 5,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152),
                            NomeCategoria = "Testes"
                        },
                        new
                        {
                            ID = 6,
                            DataAtualizacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153),
                            DataCriacao = new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153),
                            NomeCategoria = "Arquitetura"
                        });
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Property<Guid>("ID")
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

                    b.HasKey("ID");

                    b.ToTable("tb_usuario", (string)null);
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.ArtigoEntity", b =>
                {
                    b.HasOne("BlogProjetoFinal.Api.Domain.Entities.CategoriaEntity", "Categoria")
                        .WithMany("Artigos")
                        .HasForeignKey("CategoriaEntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProjetoFinal.Api.Domain.Entities.UsuarioEntity", "Usuario")
                        .WithMany("Artigos")
                        .HasForeignKey("UsuarioEntityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.CategoriaEntity", b =>
                {
                    b.Navigation("Artigos");
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.UsuarioEntity", b =>
                {
                    b.Navigation("Artigos");
                });
#pragma warning restore 612, 618
        }
    }
}
