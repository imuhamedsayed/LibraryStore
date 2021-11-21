using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnAt",
                table: "BorrowerBook",
                newName: "ReturnedAt");

            migrationBuilder.RenameColumn(
                name: "Acive",
                table: "BorrowerBook",
                newName: "Returned");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnedAt",
                table: "BorrowerBook",
                newName: "ReturnAt");

            migrationBuilder.RenameColumn(
                name: "Returned",
                table: "BorrowerBook",
                newName: "Acive");
        }
    }
}
