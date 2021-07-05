using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class mediagenre2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Media_MediaId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_MediaId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "MediaId",
                table: "Genres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MediaId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_MediaId",
                table: "Genres",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Media_MediaId",
                table: "Genres",
                column: "MediaId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
