using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardWebsite.Migrations
{
    /// <inheritdoc />
    public partial class ThirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "Collections",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Decks",
                columns: table => new
                {
                    DeckId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decks", x => x.DeckId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collections_DeckId",
                table: "Collections",
                column: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections");

            migrationBuilder.DropTable(
                name: "Decks");

            migrationBuilder.DropIndex(
                name: "IX_Collections_DeckId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "Collections");
        }
    }
}
