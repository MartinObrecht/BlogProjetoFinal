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
                name: "tb_artigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Conteudo = table.Column<string>(type: "varchar(5000)", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_artigo", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "tb_categoria",
                columns: new[] { "Id", "DataAtualizacao", "DataCriacao", "NomeCategoria" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3144), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3130), "Backend" },
                    { 2, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3146), "Frontend" },
                    { 3, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3147), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3147), "Mobile" },
                    { 4, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3148), "Cloud" },
                    { 5, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3149), "Testes" },
                    { 6, new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 9, 3, 18, 1, 58, 593, DateTimeKind.Local).AddTicks(3150), "Arquitetura" }
                });
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
