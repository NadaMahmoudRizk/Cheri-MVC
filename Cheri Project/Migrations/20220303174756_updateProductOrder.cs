using Microsoft.EntityFrameworkCore.Migrations;

namespace Cheri_Project.Migrations
{
    public partial class updateProductOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Product_Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "User_ID",
                table: "Product_Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Product_Orders");

            migrationBuilder.DropColumn(
                name: "User_ID",
                table: "Product_Orders");
        }
    }
}
