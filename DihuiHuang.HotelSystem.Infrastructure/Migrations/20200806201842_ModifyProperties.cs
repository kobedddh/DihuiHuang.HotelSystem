using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class ModifyProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "Rooms");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RTCode",
                table: "Rooms",
                column: "RTCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RTCode",
                table: "Rooms",
                column: "RTCode",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RTCode",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RTCode",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
