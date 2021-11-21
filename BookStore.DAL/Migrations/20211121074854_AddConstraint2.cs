using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class AddConstraint2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrower_BorrowerCode",
                table: "Borrower");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookCode",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BorrowerName",
                table: "Borrower",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BorrowerCode",
                table: "Borrower",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "BookStock",
                table: "Books",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "BookCode",
                table: "Books",
                newName: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Borrower_Code",
                table: "Borrower",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Code",
                table: "Books",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrower_Code",
                table: "Borrower");

            migrationBuilder.DropIndex(
                name: "IX_Books_Code",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Borrower",
                newName: "BorrowerName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Borrower",
                newName: "BorrowerCode");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Books",
                newName: "BookStock");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "BookName");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Books",
                newName: "BookCode");

            migrationBuilder.CreateIndex(
                name: "IX_Borrower_BorrowerCode",
                table: "Borrower",
                column: "BorrowerCode",
                unique: true,
                filter: "[BorrowerCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookCode",
                table: "Books",
                column: "BookCode",
                unique: true,
                filter: "[BookCode] IS NOT NULL");
        }
    }
}
