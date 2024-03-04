using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardWebsite.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections");

            migrationBuilder.AlterColumn<int>(
                name: "GradeId",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeckId",
                table: "Collections",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections");

            migrationBuilder.AlterColumn<int>(
                name: "GradeId",
                table: "Collections",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DeckId",
                table: "Collections",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Decks_DeckId",
                table: "Collections",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "DeckId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId");
        }
    }
}
