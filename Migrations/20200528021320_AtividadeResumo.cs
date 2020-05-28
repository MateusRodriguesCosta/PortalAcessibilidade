using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalAcessibilidade.Migrations
{
    public partial class AtividadeResumo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resumo",
                table: "Atividades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resumo",
                table: "Atividades");
        }
    }
}
