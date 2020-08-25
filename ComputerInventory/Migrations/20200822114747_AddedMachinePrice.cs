using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerInventory.Migrations
{
    public partial class AddedMachinePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MachinePrice",
                table: "Machine",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachinePrice",
                table: "Machine");
        }
    }
}
