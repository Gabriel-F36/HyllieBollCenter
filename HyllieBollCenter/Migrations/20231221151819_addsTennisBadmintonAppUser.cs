using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class addsTennisBadmintonAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    StringId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.StringId);
                });

            migrationBuilder.CreateTable(
                name: "Badminton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayBookingId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Badminton", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Badminton_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "StringId");
                    table.ForeignKey(
                        name: "FK_Badminton_DayBookings_DayBookingId",
                        column: x => x.DayBookingId,
                        principalTable: "DayBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tennis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayBookingId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tennis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tennis_AppUser_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUser",
                        principalColumn: "StringId");
                    table.ForeignKey(
                        name: "FK_Tennis_DayBookings_DayBookingId",
                        column: x => x.DayBookingId,
                        principalTable: "DayBookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Badminton_AppUserId",
                table: "Badminton",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Badminton_DayBookingId",
                table: "Badminton",
                column: "DayBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tennis_AppUserId",
                table: "Tennis",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tennis_DayBookingId",
                table: "Tennis",
                column: "DayBookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Badminton");

            migrationBuilder.DropTable(
                name: "Tennis");

            migrationBuilder.DropTable(
                name: "AppUser");
        }
    }
}
