using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Fix_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMalfunctioned",
                table: "Machines",
                newName: "IsMalfunctioning");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMalfunctioning",
                table: "Machines",
                newName: "IsMalfunctioned");
        }
    }
}
