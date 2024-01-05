using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class badmintonTableUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badmintons_DayBookings_DayBookingId",
                table: "Badmintons");

            migrationBuilder.DropIndex(
                name: "IX_Badmintons_DayBookingId",
                table: "Badmintons");

            migrationBuilder.DropColumn(
                name: "DayBookingId",
                table: "Badmintons");

            migrationBuilder.AddColumn<string>(
                name: "ElevenToThirteenId",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FifteenToSeventeenId",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NineToElevenId",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeventeenToNineteenId",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirteenToFifteenId",
                table: "Badmintons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElevenToThirteenId",
                table: "Badmintons");

            migrationBuilder.DropColumn(
                name: "FifteenToSeventeenId",
                table: "Badmintons");

            migrationBuilder.DropColumn(
                name: "NineToElevenId",
                table: "Badmintons");

            migrationBuilder.DropColumn(
                name: "SeventeenToNineteenId",
                table: "Badmintons");

            migrationBuilder.DropColumn(
                name: "ThirteenToFifteenId",
                table: "Badmintons");

            migrationBuilder.AddColumn<int>(
                name: "DayBookingId",
                table: "Badmintons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Badmintons_DayBookingId",
                table: "Badmintons",
                column: "DayBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badmintons_DayBookings_DayBookingId",
                table: "Badmintons",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
