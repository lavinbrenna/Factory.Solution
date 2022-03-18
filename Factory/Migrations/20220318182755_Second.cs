using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMalfunctioning",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "isOperational",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "isBeingRepaired",
                table: "Machines",
                newName: "IsBeingRepaired");

            migrationBuilder.AlterColumn<string>(
                name: "IsBeingRepaired",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddColumn<string>(
                name: "IsMalfunctioned",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsOperating",
                table: "Machines",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMalfunctioned",
                table: "Machines");

            migrationBuilder.DropColumn(
                name: "IsOperating",
                table: "Machines");

            migrationBuilder.RenameColumn(
                name: "IsBeingRepaired",
                table: "Machines",
                newName: "isBeingRepaired");

            migrationBuilder.AlterColumn<bool>(
                name: "isBeingRepaired",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isMalfunctioning",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isOperational",
                table: "Machines",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
