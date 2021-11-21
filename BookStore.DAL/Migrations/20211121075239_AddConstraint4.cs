using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class AddConstraint4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Books_ActiveReserved",
                table: "Books");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Books_ActiveReserved",
                table: "Books",
                sql: "[ActiveReserved] <= [Stock]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Books_ActiveReserved",
                table: "Books");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Books_ActiveReserved",
                table: "Books",
                sql: "[ActiveReserved] <= Stock");
        }
    }
}
