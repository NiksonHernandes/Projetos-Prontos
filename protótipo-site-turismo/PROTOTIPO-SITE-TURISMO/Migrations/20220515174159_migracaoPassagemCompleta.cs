using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace PROTOTIPO_SITE_TURISMO.Migrations
{
    public partial class migracaoPassagemCompleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PASSAGEMCOMPLETA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CidadeSaida = table.Column<string>(type: "text", nullable: true),
                    CidadeChegada = table.Column<string>(type: "text", nullable: true),
                    DataSaida = table.Column<string>(type: "text", nullable: true),
                    DataChegada = table.Column<string>(type: "text", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Detalhes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PASSAGEMCOMPLETA", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PASSAGEMCOMPLETA");
        }
    }
}
