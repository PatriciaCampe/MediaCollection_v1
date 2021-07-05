using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class function : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Persons_PersonId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MovieId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MovieId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MovieId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MovieId3",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MusicId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MusicId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_MusicId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_PodcastId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_PodcastId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_PodcastId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_SerieId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_SerieId1",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_SerieId2",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Media_SerieId3",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MovieId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MovieId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MovieId2",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MovieId3",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MusicId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MusicId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_MusicId2",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PodcastId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PodcastId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_PodcastId2",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SerieId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SerieId1",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_SerieId2",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Media_PersonId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MovieId2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MovieId3",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MusicId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MusicId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "MusicId2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PodcastId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PodcastId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PodcastId2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SerieId1",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "SerieId2",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Media");

            migrationBuilder.RenameColumn(
                name: "SerieId3",
                table: "Persons",
                newName: "MediaFunctionId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_SerieId3",
                table: "Persons",
                newName: "IX_Persons_MediaFunctionId");

            migrationBuilder.CreateTable(
                name: "MediaFunctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    MusicId = table.Column<int>(type: "int", nullable: true),
                    PodcastId = table.Column<int>(type: "int", nullable: true),
                    SerieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaFunctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaFunctions_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaFunctions_Media_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaFunctions_Media_MusicId",
                        column: x => x.MusicId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaFunctions_Media_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MediaFunctions_Media_SerieId",
                        column: x => x.SerieId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_MediaId",
                table: "MediaFunctions",
                column: "MediaId");

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
                name: "FK_Persons_MediaFunctions_MediaFunctionId",
                table: "Persons",
                column: "MediaFunctionId",
                principalTable: "MediaFunctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_MediaFunctions_MediaFunctionId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "MediaFunctions");

            migrationBuilder.RenameColumn(
                name: "MediaFunctionId",
                table: "Persons",
                newName: "SerieId3");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_MediaFunctionId",
                table: "Persons",
                newName: "IX_Persons_SerieId3");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId2",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId3",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicId1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicId2",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PodcastId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PodcastId1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PodcastId2",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieId1",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SerieId2",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Media",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId",
                table: "Persons",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId1",
                table: "Persons",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId2",
                table: "Persons",
                column: "MovieId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId3",
                table: "Persons",
                column: "MovieId3");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MusicId",
                table: "Persons",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MusicId1",
                table: "Persons",
                column: "MusicId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MusicId2",
                table: "Persons",
                column: "MusicId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PodcastId",
                table: "Persons",
                column: "PodcastId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PodcastId1",
                table: "Persons",
                column: "PodcastId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PodcastId2",
                table: "Persons",
                column: "PodcastId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SerieId",
                table: "Persons",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SerieId1",
                table: "Persons",
                column: "SerieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_SerieId2",
                table: "Persons",
                column: "SerieId2");

            migrationBuilder.CreateIndex(
                name: "IX_Media_PersonId",
                table: "Media",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Persons_PersonId",
                table: "Media",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MovieId",
                table: "Persons",
                column: "MovieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MovieId1",
                table: "Persons",
                column: "MovieId1",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MovieId2",
                table: "Persons",
                column: "MovieId2",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MovieId3",
                table: "Persons",
                column: "MovieId3",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MusicId",
                table: "Persons",
                column: "MusicId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MusicId1",
                table: "Persons",
                column: "MusicId1",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_MusicId2",
                table: "Persons",
                column: "MusicId2",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_PodcastId",
                table: "Persons",
                column: "PodcastId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_PodcastId1",
                table: "Persons",
                column: "PodcastId1",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_PodcastId2",
                table: "Persons",
                column: "PodcastId2",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_SerieId",
                table: "Persons",
                column: "SerieId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_SerieId1",
                table: "Persons",
                column: "SerieId1",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_SerieId2",
                table: "Persons",
                column: "SerieId2",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Media_SerieId3",
                table: "Persons",
                column: "SerieId3",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
