using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjetoFinal.Api.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NomeCategoria = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    NomeDeUsuario = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_artigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Conteudo = table.Column<string>(type: "varchar(5000)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_artigo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_artigo_tb_categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tb_categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_artigo_tb_usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "tb_usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tb_categoria",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "NomeCategoria" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4874), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4861), "Backend" },
                    { 2, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4876), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4875), "Frontend" },
                    { 3, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4877), "Mobile" },
                    { 4, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4880), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4879), "Cloud" },
                    { 5, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4881), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4880), "Testes" },
                    { 6, new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4884), new DateTime(2022, 9, 25, 14, 1, 47, 662, DateTimeKind.Local).AddTicks(4883), "Arquitetura" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_artigo_CategoriaId",
                table: "tb_artigo",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_artigo_UsuarioId",
                table: "tb_artigo",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_artigo");

            migrationBuilder.DropTable(
                name: "tb_categoria");

            migrationBuilder.DropTable(
                name: "tb_usuario");
        }
    }
}
