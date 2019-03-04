using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class ggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MovieMov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "MovieMov_id",
                table: "Ratings",
                newName: "movieMov_id");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MovieMov_id",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_movieMov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "movieMov_id",
                table: "Ratings",
                newName: "MovieMov_id");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_movieMov_id",
                table: "Ratings",
                newName: "IX_Ratings_MovieMov_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_MovieMov_id",
                table: "Ratings",
                column: "MovieMov_id",
                principalTable: "Movies",
                principalColumn: "Mov_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
