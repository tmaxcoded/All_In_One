using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyAPI.Migrations
{
    public partial class intialcall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moneyTakers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMoneyReceived = table.Column<bool>(type: "bit", nullable: false),
                    IsMoneySentViaBankTransfer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moneyTakers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "moneyTakers");
        }
    }
}
