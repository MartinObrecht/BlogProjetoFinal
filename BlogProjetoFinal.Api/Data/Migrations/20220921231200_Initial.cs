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
                    ID = table.Column<int>(type: "int", nullable: false),
                    NomeCategoria = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categoria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tb_usuario",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    NomeDeUsuario = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_usuario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tb_artigo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CategoriaEntityID = table.Column<int>(type: "int", nullable: false),
                    UsuarioEntityID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Conteudo = table.Column<string>(type: "varchar(5000)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_artigo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_tb_artigo_tb_categoria_CategoriaEntityID",
                        column: x => x.CategoriaEntityID,
                        principalTable: "tb_categoria",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_artigo_tb_usuario_UsuarioEntityID",
                        column: x => x.UsuarioEntityID,
                        principalTable: "tb_usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tb_categoria",
                columns: new[] { "ID", "DataAtualizacao", "DataCriacao", "NomeCategoria" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3137), "Backend" },
                    { 2, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3148), "Frontend" },
                    { 3, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149), "Mobile" },
                    { 4, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151), "Cloud" },
                    { 5, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152), "Testes" },
                    { 6, new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153), "Arquitetura" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_artigo_CategoriaEntityID",
                table: "tb_artigo",
                column: "CategoriaEntityID");

            migrationBuilder.CreateIndex(
                name: "IX_tb_artigo_UsuarioEntityID",
                table: "tb_artigo",
                column: "UsuarioEntityID");
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
