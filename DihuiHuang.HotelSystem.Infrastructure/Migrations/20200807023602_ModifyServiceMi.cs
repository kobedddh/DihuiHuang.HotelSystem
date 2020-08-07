using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class ModifyServiceMi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Services");

            migrationBuilder.CreateIndex(
                name: "IX_Services_RoomNo",
                table: "Services",
                column: "RoomNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Rooms_RoomNo",
                table: "Services",
                column: "RoomNo",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Rooms_RoomNo",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_RoomNo",
                table: "Services");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Services",
                type: "int",
                nullable: true);

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
    }
}
