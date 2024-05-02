using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NicollasDavi.Migrations
{
    /// <inheritdoc />
    public partial class cacl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "FolhaPagamento",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoFgts",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoInss",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ImpostoIrrf",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioBruto",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalarioLiquido",
                table: "FolhaPagamento",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FolhaPagamento_Funcionario_FuncionarioId",
                table: "FolhaPagamento");

            migrationBuilder.DropIndex(
                name: "IX_FolhaPagamento_FuncionarioId",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "Ano",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoFgts",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoInss",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "ImpostoIrrf",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioBruto",
                table: "FolhaPagamento");

            migrationBuilder.DropColumn(
                name: "SalarioLiquido",
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
    }
}
