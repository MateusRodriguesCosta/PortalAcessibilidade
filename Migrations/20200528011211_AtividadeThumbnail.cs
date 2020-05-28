using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalAcessibilidade.Migrations
{
    public partial class AtividadeThumbnail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Atividades",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Thumbnail",
                table: "Atividades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Thumbnail",
                table: "Atividades");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Atividades",
                newName: "id");
        }
    }
}
