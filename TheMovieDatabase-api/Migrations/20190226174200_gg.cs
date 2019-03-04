using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class gg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_Mov_id1",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "Mov_id1",
                table: "Ratings",
                newName: "MovieMov_id");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_Mov_id1",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MovieMov_id",
                table: "Ratings");

            migrationBuilder.RenameColumn(
                name: "MovieMov_id",
                table: "Ratings",
                newName: "Mov_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_MovieMov_id",
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
    }
}
