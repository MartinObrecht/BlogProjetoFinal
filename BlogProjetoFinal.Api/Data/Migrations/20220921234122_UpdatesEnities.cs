using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjetoFinal.Api.Migrations
{
    public partial class UpdatesEnities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_artigo_tb_categoria_CategoriaEntityID",
                table: "tb_artigo");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_artigo_tb_usuario_UsuarioEntityID",
                table: "tb_artigo");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tb_usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tb_categoria",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "tb_artigo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UsuarioEntityID",
                table: "tb_artigo",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "CategoriaEntityID",
                table: "tb_artigo",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_artigo_UsuarioEntityID",
                table: "tb_artigo",
                newName: "IX_tb_artigo_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_artigo_CategoriaEntityID",
                table: "tb_artigo",
                newName: "IX_tb_artigo_CategoriaId");

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7597), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7601), new DateTime(2022, 9, 21, 20, 41, 21, 906, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.AddForeignKey(
                name: "FK_tb_artigo_tb_categoria_CategoriaId",
                table: "tb_artigo",
                column: "CategoriaId",
                principalTable: "tb_categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_artigo_tb_usuario_UsuarioId",
                table: "tb_artigo",
                column: "UsuarioId",
                principalTable: "tb_usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_artigo_tb_categoria_CategoriaId",
                table: "tb_artigo");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_artigo_tb_usuario_UsuarioId",
                table: "tb_artigo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_usuario",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_categoria",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tb_artigo",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "tb_artigo",
                newName: "UsuarioEntityID");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "tb_artigo",
                newName: "CategoriaEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_tb_artigo_UsuarioId",
                table: "tb_artigo",
                newName: "IX_tb_artigo_UsuarioEntityID");

            migrationBuilder.RenameIndex(
                name: "IX_tb_artigo_CategoriaId",
                table: "tb_artigo",
                newName: "IX_tb_artigo_CategoriaEntityID");

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "tb_categoria",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153), new DateTime(2022, 9, 21, 20, 12, 0, 347, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.AddForeignKey(
                name: "FK_tb_artigo_tb_categoria_CategoriaEntityID",
                table: "tb_artigo",
                column: "CategoriaEntityID",
                principalTable: "tb_categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_artigo_tb_usuario_UsuarioEntityID",
                table: "tb_artigo",
                column: "UsuarioEntityID",
                principalTable: "tb_usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
