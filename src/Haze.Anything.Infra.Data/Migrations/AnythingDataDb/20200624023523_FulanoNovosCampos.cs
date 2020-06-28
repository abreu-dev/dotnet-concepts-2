using Microsoft.EntityFrameworkCore.Migrations;

namespace Haze.Anything.Infra.Data.Migrations.AnythingDataDb
{
    public partial class FulanoNovosCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Fulano",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorUnitario",
                table: "Fulano",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "DocumentoNumero",
                table: "Fulano",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentoTipo",
                table: "Fulano",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Fulano");

            migrationBuilder.DropColumn(
                name: "ValorUnitario",
                table: "Fulano");

            migrationBuilder.DropColumn(
                name: "DocumentoNumero",
                table: "Fulano");

            migrationBuilder.DropColumn(
                name: "DocumentoTipo",
                table: "Fulano");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Fulano",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
