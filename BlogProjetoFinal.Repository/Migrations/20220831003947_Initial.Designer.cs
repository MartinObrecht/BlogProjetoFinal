﻿// <auto-generated />
using System;
using BlogProjetoFinal.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlogProjetoFinal.Repository.Migrations
{
    [DbContext(typeof(LiquidDbContext))]
    [Migration("20220831003947_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogProjetoFinal.Domain.Entities.ArtigoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
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

                    b.ToTable("tb_artigo");
                });

            modelBuilder.Entity("BlogProjetoFinal.Domain.Entities.CategoriaEntity", b =>
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

                    b.ToTable("tb_categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6286),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 402, DateTimeKind.Local).AddTicks(4013),
                            NomeCategoria = "Backend"
                        },
                        new
                        {
                            Id = 2,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6604),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6600),
                            NomeCategoria = "Frontend"
                        },
                        new
                        {
                            Id = 3,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6607),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6606),
                            NomeCategoria = "Mobile"
                        },
                        new
                        {
                            Id = 4,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6609),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6608),
                            NomeCategoria = "Cloud"
                        },
                        new
                        {
                            Id = 5,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6611),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6610),
                            NomeCategoria = "Testes"
                        },
                        new
                        {
                            Id = 6,
                            DataAtualizacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6613),
                            DataCriacao = new DateTime(2022, 8, 30, 21, 39, 47, 403, DateTimeKind.Local).AddTicks(6612),
                            NomeCategoria = "Arquitetura"
                        });
                });

            modelBuilder.Entity("BlogProjetoFinal.Domain.Entities.UsuarioEntity", b =>
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

                    b.ToTable("tb_usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
