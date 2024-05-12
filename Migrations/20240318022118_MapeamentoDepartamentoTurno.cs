using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRepositoryPattern.Migrations
{
    /// <inheritdoc />
    public partial class MapeamentoDepartamentoTurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Turno",
                table: "TBFuncionario",
                type: "NVARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Departamento",
                table: "TBFuncionario",
                type: "NVARCHAR(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 23, 21, 18, 166, DateTimeKind.Local).AddTicks(9466),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 23, 21, 18, 167, DateTimeKind.Local).AddTicks(580),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1747));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Turno",
                table: "TBFuncionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Departamento",
                table: "TBFuncionario",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 23, 21, 18, 166, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "TBFuncionario",
                type: "SMALLDATETIME",
                maxLength: 60,
                nullable: false,
                defaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1747),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldMaxLength: 60,
                oldDefaultValue: new DateTime(2024, 3, 17, 23, 21, 18, 167, DateTimeKind.Local).AddTicks(580));
        }
    }
}
