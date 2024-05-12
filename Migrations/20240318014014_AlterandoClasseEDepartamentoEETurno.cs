using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiRepositoryPattern.Migrations
{
    /// <inheritdoc />
    public partial class AlterandoClasseEDepartamentoEETurno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(2464));

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
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 30, 3, 189, DateTimeKind.Local).AddTicks(3114));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1042));

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
                oldDefaultValue: new DateTime(2024, 3, 17, 22, 40, 14, 295, DateTimeKind.Local).AddTicks(1747));
        }
    }
}
