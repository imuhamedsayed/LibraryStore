using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class ManyToManyPrimaryKey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowerBook",
                table: "BorrowerBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowerBook",
                table: "BorrowerBook",
                columns: new[] { "BorrowerId", "BookId", "BorrowAt" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowerBook",
                table: "BorrowerBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowerBook",
                table: "BorrowerBook",
                columns: new[] { "BorrowerId", "BookId", "Returned" });
        }
    }
}
