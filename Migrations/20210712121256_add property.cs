using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyAPI.Migrations
{
    public partial class addproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "moneyTakers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "moneyTakers");
        }
    }
}
