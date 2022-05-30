using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace prototipoSiteTurismo.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CARRINHO",
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
                    table.PrimaryKey("PK_CARRINHO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HOTEIS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    DataSaida = table.Column<string>(type: "text", nullable: true),
                    DataChegada = table.Column<string>(type: "text", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Detalhes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOTEIS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LOGIN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Sobrenome = table.Column<string>(type: "text", nullable: true),
                    Endereco = table.Column<string>(type: "text", nullable: true),
                    Cidade = table.Column<string>(type: "text", nullable: true),
                    Estado = table.Column<string>(type: "text", nullable: true),
                    Sexo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Senha = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOGIN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PASSAGEM",
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
                    table.PrimaryKey("PK_PASSAGEM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CARRINHO");

            migrationBuilder.DropTable(
                name: "HOTEIS");

            migrationBuilder.DropTable(
                name: "LOGIN");

            migrationBuilder.DropTable(
                name: "PASSAGEM");
        }
    }
}
