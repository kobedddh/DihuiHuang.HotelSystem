using Microsoft.EntityFrameworkCore.Migrations;

namespace DihuiHuang.HotelSystem.Infrastructure.Migrations
{
    public partial class MidifyRelaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Services",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Services",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal));
        }
    }
}
