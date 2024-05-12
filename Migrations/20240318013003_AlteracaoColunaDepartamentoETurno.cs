using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRepositoryPattern.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoColunaDepartamentoETurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Turno",
                table: "TBFuncionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Departamento",
                table: "TBFuncionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(2464),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(3114),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5931));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Turno",
                table: "TBFuncionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Departamento",
                table: "TBFuncionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5348),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 11, 22, 18, 44, 348, DateTimeKind.Local).AddTicks(5931),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(3114));
        }
    }
}
