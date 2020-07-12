using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbalo.Migrations
{
    public partial class AlterBaloAddColKeySearch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KeySearch",
                table: "Balos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeySearch",
                table: "Balos");
        }
    }
}
