using Microsoft.EntityFrameworkCore.Migrations;

namespace PROTOTIPO_SITE_TURISMO.Migrations
{
    public partial class migracaoSemNome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "USUARIOS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "USUARIOS",
                type: "text",
                nullable: true);
        }
    }
}
