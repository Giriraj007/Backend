using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class AddMovie_Cast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie_Casts",
                columns: new[] { "id", "Act_id", "Mov_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 2 },
                    { 7, 7, 2 },
                    { 8, 8, 3 },
                    { 9, 9, 3 },
                    { 10, 10, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie_Casts",
                keyColumn: "id",
                keyValue: 10);
        }
    }
}
