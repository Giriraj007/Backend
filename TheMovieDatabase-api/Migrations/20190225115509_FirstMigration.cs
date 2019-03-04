using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheMovieDatabaseapi.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actorss",
                columns: table => new
                {
                    Act_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Act_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actorss", x => x.Act_id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Director_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Director_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Director_id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_name = table.Column<string>(nullable: true),
                    Email_id = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Mov_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mov_name = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    Avg_rating = table.Column<float>(nullable: false),
                    Mov_genrers = table.Column<string>(nullable: true),
                    Director_id = table.Column<int>(nullable: false),
                    Mov_description = table.Column<string>(maxLength: 200, nullable: true),
                    Mov_image_url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Mov_id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_Director_id",
                        column: x => x.Director_id,
                        principalTable: "Directors",
                        principalColumn: "Director_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourite_Movs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mov_id = table.Column<int>(nullable: false),
                    User_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite_Movs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Favourite_Movs_Movies_Mov_id",
                        column: x => x.Mov_id,
                        principalTable: "Movies",
                        principalColumn: "Mov_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourite_Movs_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie_Casts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Act_id = table.Column<int>(nullable: false),
                    Mov_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie_Casts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Movie_Casts_Actorss_Act_id",
                        column: x => x.Act_id,
                        principalTable: "Actorss",
                        principalColumn: "Act_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movie_Casts_Movies_Mov_id",
                        column: x => x.Mov_id,
                        principalTable: "Movies",
                        principalColumn: "Mov_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User_id = table.Column<int>(nullable: false),
                    Movie_id = table.Column<int>(nullable: false),
                    movieMov_id = table.Column<int>(nullable: true),
                    rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ratings_Users_User_id",
                        column: x => x.User_id,
                        principalTable: "Users",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_movieMov_id",
                        column: x => x.movieMov_id,
                        principalTable: "Movies",
                        principalColumn: "Mov_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_Movs_Mov_id",
                table: "Favourite_Movs",
                column: "Mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_Movs_User_id",
                table: "Favourite_Movs",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Casts_Act_id",
                table: "Movie_Casts",
                column: "Act_id");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Casts_Mov_id",
                table: "Movie_Casts",
                column: "Mov_id");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Director_id",
                table: "Movies",
                column: "Director_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_User_id",
                table: "Ratings",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_movieMov_id",
                table: "Ratings",
                column: "movieMov_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourite_Movs");

            migrationBuilder.DropTable(
                name: "Movie_Casts");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Actorss");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
