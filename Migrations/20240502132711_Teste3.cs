using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NicollasDavi.Migrations
{
    /// <inheritdoc />
    public partial class Teste3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPagamento_Funcionario_FuncionarioId",
                table: "FolhaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamento_FuncionarioId",
                table: "FolhaPagamento");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "FolhaPagamento",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_Id",
                table: "FolhaPagamento",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FolhaPagamento_Funcionario_Id",
                table: "FolhaPagamento",
                column: "Id",
                principalTable: "Funcionario",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPagamento_Funcionario_Id",
                table: "FolhaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamento_Id",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FolhaPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_FuncionarioId",
                table: "FolhaPagamento",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_FolhaPagamento_Funcionario_FuncionarioId",
                table: "FolhaPagamento",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
