using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRepositoryPattern.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    Sobrenome = table.Column<string>(type: "NVARCHAR(30)", maxLength: 30, nullable: false),
                    Departamento = table.Column<int>(type: "int", nullable: false),
                    Ativo = table.Column<bool>(type: "BIT", nullable: false),
                    Turno = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: false, defaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5348)),
                    DataAlteracao = table.Column<DateTime>(type: "SMALLDATETIME", maxLength: 60, nullable: false, defaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5931))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_Nome",
                table: "TBFuncionario",
                column: "Nome",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBFuncionario");
        }
    }
}
