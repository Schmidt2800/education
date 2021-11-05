using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServiceEduOrder.Migrations
{
    public partial class ol2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLine_Order_OrderID",
                table: "OrderLine");

            migrationBuilder.DropIndex(
                name: "IX_OrderLine_OrderID",
                table: "OrderLine");
        }
    }
}
