using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class AddingModelsPaceAndMilage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Milage",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pace",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Milage",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "pace",
                table: "AspNetUsers");
        }
    }
}
