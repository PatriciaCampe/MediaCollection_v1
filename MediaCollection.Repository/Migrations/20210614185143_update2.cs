using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Media_SerieId",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFunctions_Media_MovieId",
                table: "MediaFunctions");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFunctions_Media_MusicId",
                table: "MediaFunctions");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFunctions_Media_PodcastId",
                table: "MediaFunctions");

            migrationBuilder.DropForeignKey(
                name: "FK_MediaFunctions_Media_SerieId",
                table: "MediaFunctions");

            migrationBuilder.DropIndex(
                name: "IX_MediaFunctions_MovieId",
                table: "MediaFunctions");

            migrationBuilder.DropIndex(
                name: "IX_MediaFunctions_MusicId",
                table: "MediaFunctions");

            migrationBuilder.DropIndex(
                name: "IX_MediaFunctions_PodcastId",
                table: "MediaFunctions");

            migrationBuilder.DropIndex(
                name: "IX_MediaFunctions_SerieId",
                table: "MediaFunctions");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MediaFunctions");

            migrationBuilder.DropColumn(
                name: "MusicId",
                table: "MediaFunctions");

            migrationBuilder.DropColumn(
                name: "PodcastId",
                table: "MediaFunctions");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "MediaFunctions");

            migrationBuilder.RenameColumn(
                name: "Moviegenres",
                table: "Media",
                newName: "Moviegenre");

            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "WatchLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerieId",
                table: "Episodes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Media_SerieId",
                table: "Episodes",
                column: "SerieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Media_SerieId",
                table: "Episodes");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "WatchLists");

            migrationBuilder.RenameColumn(
                name: "Moviegenre",
                table: "Media",
                newName: "Moviegenres");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "MediaFunctions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicId",
                table: "MediaFunctions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PodcastId",
                table: "MediaFunctions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "MediaFunctions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SerieId",
                table: "Episodes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_MovieId",
                table: "MediaFunctions",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_MusicId",
                table: "MediaFunctions",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_PodcastId",
                table: "MediaFunctions",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_SerieId",
                table: "MediaFunctions",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Media_SerieId",
                table: "Episodes",
                column: "SerieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFunctions_Media_MovieId",
                table: "MediaFunctions",
                column: "MovieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFunctions_Media_MusicId",
                table: "MediaFunctions",
                column: "MusicId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFunctions_Media_PodcastId",
                table: "MediaFunctions",
                column: "PodcastId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MediaFunctions_Media_SerieId",
                table: "MediaFunctions",
                column: "SerieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
