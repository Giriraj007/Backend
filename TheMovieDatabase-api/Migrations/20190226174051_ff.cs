using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class ff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_movieMov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "movieMov_id",
                table: "Ratings",
                newName: "Mov_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_movieMov_id",
                table: "Ratings",
                newName: "IX_Ratings_Mov_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_Mov_id1",
                table: "Ratings",
                column: "Mov_id1",
                principalTable: "Movies",
                principalColumn: "Mov_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_Mov_id1",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Mov_id1",
                table: "Ratings",
                newName: "movieMov_id");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_Mov_id1",
                table: "Ratings",
                newName: "IX_Ratings_movieMov_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_movieMov_id",
                table: "Ratings",
                column: "movieMov_id",
                principalTable: "Movies",
                principalColumn: "Mov_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
