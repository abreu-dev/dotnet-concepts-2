using Microsoft.EntityFrameworkCore.Migrations;

namespace Haze.Authentication.Infra.Data.Migrations.AuthenticationDataDb
{
    public partial class EmailAndFailedAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FailedAttemptsInARow",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FailedAttemptsInARow",
                table: "User");
        }
    }
}
