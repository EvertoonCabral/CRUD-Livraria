using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoLivraria.Migrations
{
    /// <inheritdoc />
    public partial class criacaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LivrroEmprestado",
                table: "Emprestimos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LivrroEmprestado",
                table: "Emprestimos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
