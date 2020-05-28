using Microsoft.EntityFrameworkCore.Migrations;

namespace PortalAcessibilidade.Migrations
{
    public partial class FerramentaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ferramentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true),
                    AtividadeId = table.Column<int>(nullable: true),
                    Resumo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ferramentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ferramentas_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ferramentas_AtividadeId",
                table: "Ferramentas",
                column: "AtividadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ferramentas");
        }
    }
}
