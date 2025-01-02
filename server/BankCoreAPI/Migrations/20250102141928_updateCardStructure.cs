using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateCardStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BlockedAt",
                table: "Cards",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BlockedAt",
                table: "Accounts",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockedAt",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BlockedAt",
                table: "Accounts");
        }
    }
}
