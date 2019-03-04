using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class newSeeding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Director_id", "Director_name" },
                values: new object[] { 1, "Zoya Akhtar" });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Director_id", "Director_name" },
                values: new object[] { 2, "Sankalp Reddy" });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Director_id", "Director_name" },
                values: new object[] { 3, "Pa.Ranjith" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Mov_id", "Avg_rating", "Director_id", "Mov_description", "Mov_genrers", "Mov_image_url", "Mov_name", "year" },
                values: new object[] { 1, 7.5f, 1, "Gully Boy is a 2019 Indian Hindi-language musical drama film written by Zoya Akhtar and Reema Kagti, and directed by Akhtar.", "Drama", "https://upload.wikimedia.org/wikipedia/en/0/07/Gully_Boy_poster.jpg", "Gully Boy", 2019 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Mov_id", "Avg_rating", "Director_id", "Mov_description", "Mov_genrers", "Mov_image_url", "Mov_name", "year" },
                values: new object[] { 2, 7.6f, 2, "The Ghazi Attack (Ghazi in Telugu) is a 2017 Indian war film written, and directed by Sankalp Reddy.", "Action", "https://upload.wikimedia.org/wikipedia/en/e/e7/The_Ghazi_Attack_Poster.jpg", "The Gahzi Attack", 2017 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Mov_id", "Avg_rating", "Director_id", "Mov_description", "Mov_genrers", "Mov_image_url", "Mov_name", "year" },
                values: new object[] { 3, 7.1f, 3, "Kabali is a 2016 Indian Tamil-language gangster film written and directed by Pa. Ranjith and produced by Kalaipuli S. Thanu.", "Thriller", "https://upload.wikimedia.org/wikipedia/en/9/9e/Rajinikanth_in_Kabali.jpg", "Kabali", 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Mov_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Mov_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Mov_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Director_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Director_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Director_id",
                keyValue: 3);
        }
    }
}
