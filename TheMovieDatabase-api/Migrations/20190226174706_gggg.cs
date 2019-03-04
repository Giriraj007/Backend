using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class gggg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_movieMov_id",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_movieMov_id",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "movieMov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Movie_id",
                table: "Ratings",
                newName: "Mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_Mov_id",
                table: "Ratings",
                column: "Mov_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_Mov_id",
                table: "Ratings",
                column: "Mov_id",
                principalTable: "Movies",
                principalColumn: "Mov_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_Mov_id",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_Mov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Mov_id",
                table: "Ratings",
                newName: "Movie_id");

            migrationBuilder.AddColumn<int>(
                name: "movieMov_id",
                table: "Ratings",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_movieMov_id",
                table: "Ratings",
                column: "movieMov_id");

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
