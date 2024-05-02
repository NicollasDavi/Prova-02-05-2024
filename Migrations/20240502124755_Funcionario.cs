using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NicollasDavi.Migrations
{
    /// <inheritdoc />
    public partial class Funcionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionario",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Funcionario",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funcionario",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Funcionario",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Funcionario",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Funcionario",
                newName: "Id");
        }
    }
}
