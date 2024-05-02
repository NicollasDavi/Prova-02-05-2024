using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NicollasDavi.Migrations
{
    /// <inheritdoc />
    public partial class Funcionari : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Cpf = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FolhaPagamento",
                columns: table => new
                {
                    FolhaId = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Mes = table.Column<int>(type: "INTEGER", nullable: false),
                    FuncionarioId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FolhaPagamento", x => x.FolhaId);
                    table.ForeignKey(
                        name: "FK_FolhaPagamento_Funcionario_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "Funcionario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FolhaPagamento_FuncionarioId",
                table: "FolhaPagamento",
                column: "FuncionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FolhaPagamento");

            migrationBuilder.DropTable(
                name: "Funcionario");
        }
    }
}
