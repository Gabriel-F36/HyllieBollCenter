using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class ChangedTableNamesToPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badminton_AppUser_AppUserId",
                table: "Badminton");

            migrationBuilder.DropForeignKey(
                name: "FK_Badminton_DayBookings_DayBookingId",
                table: "Badminton");

            migrationBuilder.DropForeignKey(
                name: "FK_Tennis_AppUser_AppUserId",
                table: "Tennis");

            migrationBuilder.DropForeignKey(
                name: "FK_Tennis_DayBookings_DayBookingId",
                table: "Tennis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tennis",
                table: "Tennis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Badminton",
                table: "Badminton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser");

            migrationBuilder.RenameTable(
                name: "Tennis",
                newName: "Tenniss");

            migrationBuilder.RenameTable(
                name: "Badminton",
                newName: "Badmintons");

            migrationBuilder.RenameTable(
                name: "AppUser",
                newName: "AppUsers");

            migrationBuilder.RenameIndex(
                name: "IX_Tennis_DayBookingId",
                table: "Tenniss",
                newName: "IX_Tenniss_DayBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Tennis_AppUserId",
                table: "Tenniss",
                newName: "IX_Tenniss_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Badminton_DayBookingId",
                table: "Badmintons",
                newName: "IX_Badmintons_DayBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Badminton_AppUserId",
                table: "Badmintons",
                newName: "IX_Badmintons_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tenniss",
                table: "Tenniss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Badmintons",
                table: "Badmintons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badmintons_AppUsers_AppUserId",
                table: "Badmintons",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badmintons_DayBookings_DayBookingId",
                table: "Badmintons",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenniss_AppUsers_AppUserId",
                table: "Tenniss",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenniss_DayBookings_DayBookingId",
                table: "Tenniss",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badmintons_AppUsers_AppUserId",
                table: "Badmintons");

            migrationBuilder.DropForeignKey(
                name: "FK_Badmintons_DayBookings_DayBookingId",
                table: "Badmintons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenniss_AppUsers_AppUserId",
                table: "Tenniss");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenniss_DayBookings_DayBookingId",
                table: "Tenniss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tenniss",
                table: "Tenniss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Badmintons",
                table: "Badmintons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.RenameTable(
                name: "Tenniss",
                newName: "Tennis");

            migrationBuilder.RenameTable(
                name: "Badmintons",
                newName: "Badminton");

            migrationBuilder.RenameTable(
                name: "AppUsers",
                newName: "AppUser");

            migrationBuilder.RenameIndex(
                name: "IX_Tenniss_DayBookingId",
                table: "Tennis",
                newName: "IX_Tennis_DayBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Tenniss_AppUserId",
                table: "Tennis",
                newName: "IX_Tennis_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Badmintons_DayBookingId",
                table: "Badminton",
                newName: "IX_Badminton_DayBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_Badmintons_AppUserId",
                table: "Badminton",
                newName: "IX_Badminton_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tennis",
                table: "Tennis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Badminton",
                table: "Badminton",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUser",
                table: "AppUser",
                column: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badminton_AppUser_AppUserId",
                table: "Badminton",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Badminton_DayBookings_DayBookingId",
                table: "Badminton",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tennis_AppUser_AppUserId",
                table: "Tennis",
                column: "AppUserId",
                principalTable: "AppUser",
                principalColumn: "StringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tennis_DayBookings_DayBookingId",
                table: "Tennis",
                column: "DayBookingId",
                principalTable: "DayBookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
