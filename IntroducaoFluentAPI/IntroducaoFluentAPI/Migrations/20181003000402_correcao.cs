using Microsoft.EntityFrameworkCore.Migrations;

namespace IntroducaoFluentAPI.Migrations
{
    public partial class correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "float",
                table: "Pessoas",
                newName: "Peso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Pessoas",
                newName: "float");
        }
    }
}
