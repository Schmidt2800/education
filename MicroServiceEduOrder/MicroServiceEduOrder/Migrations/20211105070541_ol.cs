using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroServiceEduOrder.Migrations
{
    public partial class ol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderLineEf_Orders_OrderID",
                table: "OrderLineEf");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLineEf",
                table: "OrderLineEf");

            migrationBuilder.DropIndex(
                name: "IX_OrderLineEf_OrderID",
                table: "OrderLineEf");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderLineEf",
                newName: "OrderLine");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderLine",
                table: "OrderLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "OrderLine",
                newName: "OrderLineEf");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderLineEf",
                table: "OrderLineEf",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineEf_OrderID",
                table: "OrderLineEf",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderLineEf_Orders_OrderID",
                table: "OrderLineEf",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
