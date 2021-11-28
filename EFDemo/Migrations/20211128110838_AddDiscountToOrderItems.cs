using Microsoft.EntityFrameworkCore.Migrations;

namespace EFDemo.Migrations
{
    public partial class AddDiscountToOrderItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "OrderItem",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderItem");
        }
    }
}
