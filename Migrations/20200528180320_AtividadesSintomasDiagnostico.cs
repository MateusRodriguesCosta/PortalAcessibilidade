using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalAcessibilidade.Migrations
{
    public partial class AtividadesSintomasDiagnostico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diagnostico",
                table: "Atividades",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sintomas",
                table: "Atividades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diagnostico",
                table: "Atividades");

            migrationBuilder.DropColumn(
                name: "Sintomas",
                table: "Atividades");
        }
    }
}
