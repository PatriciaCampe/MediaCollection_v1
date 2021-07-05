using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Moviegenre",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "MusicGenre",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "Serie_Genre",
                table: "Media");

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genres_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MediaId",
                table: "Genres",
                column: "MediaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Media",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Moviegenre",
                table: "Media",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicGenre",
                table: "Media",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Serie_Genre",
                table: "Media",
                type: "int",
                nullable: true);
        }
    }
}
