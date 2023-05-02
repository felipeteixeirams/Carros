using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Carros.Data.Migrations
{
    public partial class CreateDBCarros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumoCombustivels",
                columns: table => new
                {
                    NumeroDeSerie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidade = table.Column<int>(type: "int", nullable: false),
                    Portador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CombustivelAtual = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumoCombustivels", x => x.NumeroDeSerie);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsumoCombustivels");
        }
    }
}
