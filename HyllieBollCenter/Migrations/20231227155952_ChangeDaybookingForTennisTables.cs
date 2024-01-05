using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class ChangeDaybookingForTennisTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenniss_DayBookings_DayBookingId",
                table: "Tenniss");

            migrationBuilder.DropIndex(
                name: "IX_Tenniss_DayBookingId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "DayBookingId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "NineteenToTwentyoneId",
                table: "DayBookings");

            migrationBuilder.AddColumn<string>(
                name: "ElevenToThirteenId",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FifteenToSeventeenId",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NineToElevenId",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeventeenToNineteenId",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirteenToFifteenId",
                table: "Tenniss",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElevenToThirteenId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "FifteenToSeventeenId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "NineToElevenId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "SeventeenToNineteenId",
                table: "Tenniss");

            migrationBuilder.DropColumn(
                name: "ThirteenToFifteenId",
                table: "Tenniss");

            migrationBuilder.AddColumn<int>(
                name: "DayBookingId",
                table: "Tenniss",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NineteenToTwentyoneId",
                table: "DayBookings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tenniss_DayBookingId",
                table: "Tenniss",
                column: "DayBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenniss_DayBookings_DayBookingId",
                table: "Tenniss",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
