using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.DAL.Migrations
{
    public partial class AddConstraint5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Books_ActiveReserved_GreatherThanZero",
                table: "Books",
                sql: "[ActiveReserved] >= 0");

            migrationBuilder.AddCheckConstraint(
                name: "CK_Books_Stock_GreaterThanZero",
                table: "Books",
                sql: "[Stock] > 0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Books_ActiveReserved_GreatherThanZero",
                table: "Books");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Books_Stock_GreaterThanZero",
                table: "Books");
        }
    }
}
