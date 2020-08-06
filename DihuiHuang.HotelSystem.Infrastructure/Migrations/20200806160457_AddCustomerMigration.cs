using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class AddCustomerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RTDesc",
                table: "RoomTypes",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNo = table.Column<int>(nullable: false),
                    CName = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 40, nullable: true),
                    Checkin = table.Column<DateTime>(nullable: false),
                    TotalPersons = table.Column<int>(nullable: false),
                    BookingDays = table.Column<int>(nullable: false),
                    Advance = table.Column<decimal>(nullable: false),
                    RoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RoomId",
                table: "Customers",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "RTDesc",
                table: "RoomTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);
        }
    }
}
