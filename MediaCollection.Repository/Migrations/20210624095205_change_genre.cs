using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class change_genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaGenres");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Media",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Media");

            migrationBuilder.CreateTable(
                name: "MediaGenres",
                columns: table => new
                {
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaGenres", x => new { x.MediaId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MediaGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaGenres_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_GenreId",
                table: "MediaGenres",
                column: "GenreId");
        }
    }
}
