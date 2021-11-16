using Microsoft.EntityFrameworkCore.Migrations;

namespace TictacToe.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    BoardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.BoardId);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Xcoordinate = table.Column<int>(type: "int", nullable: false),
                    Ycoordinate = table.Column<int>(type: "int", nullable: false),
                    Sign = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    BoardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Boards",
                column: "BoardId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "BoardId", "Sign", "Xcoordinate", "Ycoordinate" },
                values: new object[,]
                {
                    { 1, 1, " ", 0, 0 },
                    { 2, 1, " ", 0, 1 },
                    { 3, 1, " ", 0, 2 },
                    { 4, 1, " ", 1, 0 },
                    { 5, 1, " ", 1, 1 },
                    { 6, 1, " ", 1, 2 },
                    { 7, 1, " ", 2, 0 },
                    { 8, 1, " ", 2, 1 },
                    { 9, 1, " ", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fields_BoardId",
                table: "Fields",
                column: "BoardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Boards");
        }
    }
}
