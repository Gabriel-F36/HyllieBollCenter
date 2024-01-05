using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class AttrubiteDayToTennisAndBadmintonTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Day",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Badmintons");
        }
    }
}
