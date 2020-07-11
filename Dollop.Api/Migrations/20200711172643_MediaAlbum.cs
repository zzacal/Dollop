using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Dollop.Api.Migrations
{
    public partial class MediaAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Album_AlbumId",
                table: "Media");

            migrationBuilder.DropIndex(
                name: "IX_Media_AlbumId",
                table: "Media");

            migrationBuilder.DropColumn(
                name: "AlbumId",
                table: "Media");

            migrationBuilder.CreateTable(
                name: "MediaAlbum",
                columns: table => new
                {
                    AlbumId = table.Column<Guid>(nullable: false),
                    MediaItemId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaAlbum", x => new { x.AlbumId, x.MediaItemId });
                    table.ForeignKey(
                        name: "FK_MediaAlbum_Album_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MediaAlbum_Media_MediaItemId",
                        column: x => x.MediaItemId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MediaAlbum_MediaItemId",
                table: "MediaAlbum",
                column: "MediaItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaAlbum");

            migrationBuilder.AddColumn<Guid>(
                name: "AlbumId",
                table: "Media",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Media_AlbumId",
                table: "Media",
                column: "AlbumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Album_AlbumId",
                table: "Media",
                column: "AlbumId",
                principalTable: "Album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
