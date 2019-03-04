using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class Addremaining : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_id", "Email_id", "User_name", "password" },
                values: new object[] { 1, "bhatiagiriraj007@gmail.com", "Giriraj", "123456" });

            migrationBuilder.InsertData(
                table: "Favourite_Movs",
                columns: new[] { "id", "Mov_id", "User_id" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "id", "Movie_id", "User_id", "movieMov_id", "rating" },
                values: new object[] { 1, 1, 1, null, 7.5f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favourite_Movs",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_id",
                keyValue: 1);
        }
    }
}
