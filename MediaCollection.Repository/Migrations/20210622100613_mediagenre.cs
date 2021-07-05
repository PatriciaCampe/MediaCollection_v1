using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class mediagenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreMedia");

            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "Genres",
                type: "int",
                nullable: true);

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
                name: "IX_Genres_MediaId",
                table: "Genres",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaGenres_GenreId",
                table: "MediaGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Media_MediaId",
                table: "Genres",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Media_MediaId",
                table: "Genres");

            migrationBuilder.DropTable(
                name: "MediaGenres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MediaId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Genres");

            migrationBuilder.CreateTable(
                name: "GenreMedia",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMedia", x => new { x.GenresId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_GenreMedia_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMedia_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreMedia_MediaId",
                table: "GenreMedia",
                column: "MediaId");
        }
    }
}
