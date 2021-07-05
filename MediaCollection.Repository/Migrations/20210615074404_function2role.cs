using Microsoft.EntityFrameworkCore.Migrations;

namespace MediaCollection.Repository.Migrations
{
    public partial class function2role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_MediaFunctions_MediaFunctionId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "MediaFunctions");

            migrationBuilder.RenameColumn(
                name: "MediaFunctionId",
                table: "Persons",
                newName: "MediaRoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_MediaFunctionId",
                table: "Persons",
                newName: "IX_Persons_MediaRoleId");

            migrationBuilder.CreateTable(
                name: "MediaRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaRoles_Media_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaRoles_MediaId",
                table: "MediaRoles",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_MediaRoles_MediaRoleId",
                table: "Persons",
                column: "MediaRoleId",
                principalTable: "MediaRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_MediaRoles_MediaRoleId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "MediaRoles");

            migrationBuilder.RenameColumn(
                name: "MediaRoleId",
                table: "Persons",
                newName: "MediaFunctionId");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_MediaRoleId",
                table: "Persons",
                newName: "IX_Persons_MediaFunctionId");

            migrationBuilder.CreateTable(
                name: "MediaFunctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Function = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaFunctions_MediaId",
                table: "MediaFunctions",
                column: "MediaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_MediaFunctions_MediaFunctionId",
                table: "Persons",
                column: "MediaFunctionId",
                principalTable: "MediaFunctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
