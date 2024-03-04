using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardWebsite.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "Collections",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Score = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Collections_GradeId",
                table: "Collections",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections",
                column: "GradeId",
                principalTable: "Grades",
                principalColumn: "GradeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_Grades_GradeId",
                table: "Collections");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Collections_GradeId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "Collections");
        }
    }
}
