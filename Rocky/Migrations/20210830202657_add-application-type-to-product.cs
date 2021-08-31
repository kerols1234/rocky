using Microsoft.EntityFrameworkCore.Migrations;

namespace Rocky.Migrations
{
    public partial class addapplicationtypetoproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_products_applicationTypes_ApplicationId",
                table: "products",
                column: "ApplicationId",
                principalTable: "applicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.CreateIndex(
                name: "IX_products_ApplicationId",
                table: "products",
                column: "ApplicationId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_applicationTypes_ApplicationId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ApplicationId",
                table: "products");
        }
    }
}
