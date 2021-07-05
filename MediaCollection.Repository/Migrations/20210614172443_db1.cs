using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WatchLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Season = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SerieId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    MovieId1 = table.Column<int>(type: "int", nullable: true),
                    MovieId2 = table.Column<int>(type: "int", nullable: true),
                    MovieId3 = table.Column<int>(type: "int", nullable: true),
                    MusicId = table.Column<int>(type: "int", nullable: true),
                    MusicId1 = table.Column<int>(type: "int", nullable: true),
                    MusicId2 = table.Column<int>(type: "int", nullable: true),
                    PodcastId = table.Column<int>(type: "int", nullable: true),
                    PodcastId1 = table.Column<int>(type: "int", nullable: true),
                    PodcastId2 = table.Column<int>(type: "int", nullable: true),
                    SerieId = table.Column<int>(type: "int", nullable: true),
                    SerieId1 = table.Column<int>(type: "int", nullable: true),
                    SerieId2 = table.Column<int>(type: "int", nullable: true),
                    SerieId3 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true),
                    WatchListId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moviegenres = table.Column<int>(type: "int", nullable: true),
                    MusicGenre = table.Column<int>(type: "int", nullable: true),
                    Lyrics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Podcast_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<int>(type: "int", nullable: true),
                    Serie_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Serie_Genre = table.Column<int>(type: "int", nullable: true),
                    AmountSeasons = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Media_WatchLists_WatchListId",
                        column: x => x.WatchListId,
                        principalTable: "WatchLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SerieId",
                table: "Episodes",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_PersonId",
                table: "Media",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_WatchListId",
                table: "Media",
                column: "WatchListId");

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
                name: "IX_Persons_SerieId3",
                table: "Persons",
                column: "SerieId3");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MediaId",
                table: "Reviews",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Media_SerieId",
                table: "Episodes",
                column: "SerieId",
                principalTable: "Media",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "WatchLists");
        }
    }
}
