using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class ModifyCust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoomId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomNo",
                table: "Customers",
                column: "RoomNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomNo",
                table: "Customers",
                column: "RoomNo",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Rooms_RoomNo",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RoomNo",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomId",
                table: "Customers",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Rooms_RoomId",
                table: "Customers",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
