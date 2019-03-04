using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class AddActor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actorss",
                columns: new[] { "Act_id", "Act_image_url", "Act_name" },
                values: new object[,]
                {
                    { 1, "https://filmfare.wwmindia.com/content/2019/jan/ranveersinghweb1547459320.jpg", "Ranveer Singh" },
                    { 2, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/gu1Sf68cuMgSxSXIsVqG00aCmSy.jpg", "Alia Bhatt" },
                    { 3, "https://upload.wikimedia.org/wikipedia/commons/6/68/Kalki_Koechlin_launches_beautifulhomes.jpg", "Kalki Koechin" },
                    { 4, "https://m.media-amazon.com/images/M/MV5BYjgwNDZlZGQtZjFiNy00ODQ5LWEzZGUtNWQzNDc4M2QxNmZiXkEyXkFqcGdeQXVyMjIxODkxMzk@._V1_UX214_CR0,0,214,317_AL__QL50.jpg", "Kubbra Sait" },
                    { 5, "https://image.tmdb.org/t/p/w600_and_h900_bestv2/bLSjiy51UPjVnTYRDmgRUy1VOwD.jpg", "Vijay Raaz" },
                    { 6, "https://static.toiimg.com/thumb/imgsize-78019,msid-56888342,width-400,resizemode-4/56888342.jpg", "Rana Duggubati" },
                    { 7, "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201812/taapsee_pannu_0.jpeg?swpYv59n0DftpyK.d0ZReuGVJML8VoRw", "Taapsee Pannu" },
                    { 8, "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg/220px-Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg", "Rajinikanth" },
                    { 9, "https://timesofindia.indiatimes.com/thumb/msid-60900885,width-800,height-600,resizemode-4/60900885.jpg", "Sai Dhanshik" },
                    { 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Radhika_Apte_snapped_on_the_sets_of_Midnight_Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg/220px-Radhika_Apte_snapped_on_the_sets_of_Midnight_Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg", "Radhika Apte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actorss",
                keyColumn: "Act_id",
                keyValue: 10);
        }
    }
}
