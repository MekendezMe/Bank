using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class updateStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountId",
                table: "AccountTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_CardTransactions_Cards_CardId",
                table: "CardTransactions");

            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "CardTransactions",
                newName: "CardToId");

            migrationBuilder.RenameIndex(
                name: "IX_CardTransactions_CardId",
                table: "CardTransactions",
                newName: "IX_CardTransactions_CardToId");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AccountTransactions",
                newName: "AccountToId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountTransactions_AccountId",
                table: "AccountTransactions",
                newName: "IX_AccountTransactions_AccountToId");

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "CardTransactions",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<long>(
                name: "CardFromId",
                table: "CardTransactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "AccountFromId",
                table: "AccountTransactions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "AccountTransactions",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_CardTransactions_CardFromId",
                table: "CardTransactions",
                column: "CardFromId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransactions_AccountFromId",
                table: "AccountTransactions",
                column: "AccountFromId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountFromId",
                table: "AccountTransactions",
                column: "AccountFromId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountToId",
                table: "AccountTransactions",
                column: "AccountToId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardTransactions_Cards_CardFromId",
                table: "CardTransactions",
                column: "CardFromId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardTransactions_Cards_CardToId",
                table: "CardTransactions",
                column: "CardToId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountFromId",
                table: "AccountTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountToId",
                table: "AccountTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_CardTransactions_Cards_CardFromId",
                table: "CardTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_CardTransactions_Cards_CardToId",
                table: "CardTransactions");

            migrationBuilder.DropIndex(
                name: "IX_CardTransactions_CardFromId",
                table: "CardTransactions");

            migrationBuilder.DropIndex(
                name: "IX_AccountTransactions_AccountFromId",
                table: "AccountTransactions");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "CardTransactions");

            migrationBuilder.DropColumn(
                name: "CardFromId",
                table: "CardTransactions");

            migrationBuilder.DropColumn(
                name: "AccountFromId",
                table: "AccountTransactions");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "AccountTransactions");

            migrationBuilder.RenameColumn(
                name: "CardToId",
                table: "CardTransactions",
                newName: "CardId");

            migrationBuilder.RenameIndex(
                name: "IX_CardTransactions_CardToId",
                table: "CardTransactions",
                newName: "IX_CardTransactions_CardId");

            migrationBuilder.RenameColumn(
                name: "AccountToId",
                table: "AccountTransactions",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_AccountTransactions_AccountToId",
                table: "AccountTransactions",
                newName: "IX_AccountTransactions_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountTransactions_Accounts_AccountId",
                table: "AccountTransactions",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CardTransactions_Cards_CardId",
                table: "CardTransactions",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
