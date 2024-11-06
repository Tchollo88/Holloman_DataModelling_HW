using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Holloman_DataModelling_HW.Migrations
{
    /// <inheritdoc />
    public partial class CustomerLikesTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Likes_Customers_CustomerId",
                table: "Likes");

            migrationBuilder.DropIndex(
                name: "IX_Likes_CustomerId",
                table: "Likes");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Likes");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerLikes_CustomerId",
                table: "CustomerLikes",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerLikes_Customers_CustomerId",
                table: "CustomerLikes",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerLikes_Customers_CustomerId",
                table: "CustomerLikes");

            migrationBuilder.DropIndex(
                name: "IX_CustomerLikes_CustomerId",
                table: "CustomerLikes");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Likes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Likes_CustomerId",
                table: "Likes",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Likes_Customers_CustomerId",
                table: "Likes",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }
    }
}
