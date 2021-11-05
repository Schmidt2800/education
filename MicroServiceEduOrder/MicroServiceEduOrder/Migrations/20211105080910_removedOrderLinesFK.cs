using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServiceEduOrder.Migrations
{
    public partial class removedOrderLinesFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order_OrderID",
                table: "OrderLine");

            migrationBuilder.DropIndex(
                name: "IX_OrderLine_OrderID",
                table: "OrderLine");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "OrderLine",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "OrderLine");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLine_OrderID",
                table: "OrderLine",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLine_Order_OrderID",
                table: "OrderLine",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
