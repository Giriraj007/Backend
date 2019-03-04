using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class FirstMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Movies_Director_id",
                table: "Movies");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Director_id",
                table: "Movies",
                column: "Director_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Movies_Director_id",
                table: "Movies");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Director_id",
                table: "Movies",
                column: "Director_id");
        }
    }
}
