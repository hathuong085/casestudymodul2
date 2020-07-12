using Microsoft.EntityFrameworkCore.Migrations;

namespace shopbalo.Migrations
{
    public partial class AlterBaloAddPriceSale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "Balos",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Sale",
                table: "Balos",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Balos");

            migrationBuilder.DropColumn(
                name: "Sale",
                table: "Balos");
        }
    }
}
