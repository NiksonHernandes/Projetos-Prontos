using Microsoft.EntityFrameworkCore.Migrations;

namespace PROTOTIPO_SITE_TURISMO.Migrations
{
    public partial class migracaoPassagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "LOGIN");

            migrationBuilder.AlterColumn<int>(
                name: "Preco",
                table: "Passagens",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LOGIN",
                table: "LOGIN",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LOGIN",
                table: "LOGIN");

            migrationBuilder.RenameTable(
                name: "LOGIN",
                newName: "Login");

            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Passagens",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "Id");
        }
    }
}
