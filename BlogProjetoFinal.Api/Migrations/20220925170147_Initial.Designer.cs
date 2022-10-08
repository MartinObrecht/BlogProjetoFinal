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
    [Migration("20220925170147_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Artigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
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

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("tb_artigo", (string)null);
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Categoria", b =>
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
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4874),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4861),
                            NomeCategoria = "Backend"
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4876),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4875),
                            NomeCategoria = "Frontend"
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4878),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4877),
                            NomeCategoria = "Mobile"
                        },
                        new
                        {
                            Id = 4,
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4880),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4879),
                            NomeCategoria = "Cloud"
                        },
                        new
                        {
                            Id = 5,
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4881),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4880),
                            NomeCategoria = "Testes"
                        },
                        new
                        {
                            Id = 6,
                            DataAtualizacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4884),
                            DataCriacao = new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4883),
                            NomeCategoria = "Arquitetura"
                        });
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Usuario", b =>
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

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Artigo", b =>
                {
                    b.HasOne("BlogProjetoFinal.Api.Domain.Entities.Categoria", "Categoria")
                        .WithMany("Artigos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogProjetoFinal.Api.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Artigos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Artigos");
                });

            modelBuilder.Entity("BlogProjetoFinal.Api.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Artigos");
                });
#pragma warning restore 612, 618
        }
    }
}