using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class AddRoomMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Services",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTCode = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomId",
                table: "Services",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Services");
        }
    }
}
