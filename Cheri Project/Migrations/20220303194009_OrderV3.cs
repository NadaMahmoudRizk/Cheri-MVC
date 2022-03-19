using Microsoft.EntityFrameworkCore.Migrations;

namespace Cheri_Project.Migrations
{
    public partial class OrderV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Product_Orders",
                newName: "OrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Product_Orders",
                newName: "ID");
        }
    }
}
