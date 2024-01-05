using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HyllieBollCenter.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DayBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NineToElevenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElevenToThirteenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirteenToFifteenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FifteenToSeventeenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeventeenToNineteenId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NineteenToTwentyoneId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayBookings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayBookings");
        }
    }
}
