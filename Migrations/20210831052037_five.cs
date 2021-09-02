using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductDilvery_MVC.Migrations
{
    public partial class five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_clientId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Comapny_comapnyId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_productId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_comapnyId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Client",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "comapnyId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "Order",
                newName: "Productid");

            migrationBuilder.RenameColumn(
                name: "clientId",
                table: "Order",
                newName: "Clientid");

            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Order",
                newName: "Companyid");

            migrationBuilder.RenameIndex(
                name: "IX_Order_productId",
                table: "Order",
                newName: "IX_Order_Productid");

            migrationBuilder.RenameIndex(
                name: "IX_Order_clientId",
                table: "Order",
                newName: "IX_Order_Clientid");

            migrationBuilder.AlterColumn<int>(
                name: "Productid",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Clientid",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_Companyid",
                table: "Order",
                column: "Companyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_Clientid",
                table: "Order",
                column: "Clientid",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Comapny_Companyid",
                table: "Order",
                column: "Companyid",
                principalTable: "Comapny",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_Productid",
                table: "Order",
                column: "Productid",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_Clientid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Comapny_Companyid",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Product_Productid",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_Companyid",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Productid",
                table: "Order",
                newName: "productId");

            migrationBuilder.RenameColumn(
                name: "Clientid",
                table: "Order",
                newName: "clientId");

            migrationBuilder.RenameColumn(
                name: "Companyid",
                table: "Order",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Productid",
                table: "Order",
                newName: "IX_Order_productId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_Clientid",
                table: "Order",
                newName: "IX_Order_clientId");

            migrationBuilder.AlterColumn<int>(
                name: "productId",
                table: "Order",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "clientId",
                table: "Order",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Order",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Company",
                table: "Order",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "comapnyId",
                table: "Order",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_comapnyId",
                table: "Order",
                column: "comapnyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_clientId",
                table: "Order",
                column: "clientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Comapny_comapnyId",
                table: "Order",
                column: "comapnyId",
                principalTable: "Comapny",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Product_productId",
                table: "Order",
                column: "productId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
