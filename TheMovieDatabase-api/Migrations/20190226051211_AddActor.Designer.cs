﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheMovieDatabase_api.Models;

namespace TheMovieDatabaseapi.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20190226051211_AddActor")]
    partial class AddActor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheMovieDatabase_api.Models.Actor", b =>
                {
                    b.Property<int>("Act_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Act_image_url")
                        .HasMaxLength(500);

                    b.Property<string>("Act_name");

                    b.HasKey("Act_id");

                    b.ToTable("Actorss");

                    b.HasData(
                        new { Act_id = 1, Act_image_url = "https://filmfare.wwmindia.com/content/2019/jan/ranveersinghweb1547459320.jpg", Act_name = "Ranveer Singh" },
                        new { Act_id = 2, Act_image_url = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/gu1Sf68cuMgSxSXIsVqG00aCmSy.jpg", Act_name = "Alia Bhatt" },
                        new { Act_id = 3, Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/6/68/Kalki_Koechlin_launches_beautifulhomes.jpg", Act_name = "Kalki Koechin" },
                        new { Act_id = 4, Act_image_url = "https://m.media-amazon.com/images/M/MV5BYjgwNDZlZGQtZjFiNy00ODQ5LWEzZGUtNWQzNDc4M2QxNmZiXkEyXkFqcGdeQXVyMjIxODkxMzk@._V1_UX214_CR0,0,214,317_AL__QL50.jpg", Act_name = "Kubbra Sait" },
                        new { Act_id = 5, Act_image_url = "https://image.tmdb.org/t/p/w600_and_h900_bestv2/bLSjiy51UPjVnTYRDmgRUy1VOwD.jpg", Act_name = "Vijay Raaz" },
                        new { Act_id = 6, Act_image_url = "https://static.toiimg.com/thumb/imgsize-78019,msid-56888342,width-400,resizemode-4/56888342.jpg", Act_name = "Rana Duggubati" },
                        new { Act_id = 7, Act_image_url = "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201812/taapsee_pannu_0.jpeg?swpYv59n0DftpyK.d0ZReuGVJML8VoRw", Act_name = "Taapsee Pannu" },
                        new { Act_id = 8, Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg/220px-Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg", Act_name = "Rajinikanth" },
                        new { Act_id = 9, Act_image_url = "https://timesofindia.indiatimes.com/thumb/msid-60900885,width-800,height-600,resizemode-4/60900885.jpg", Act_name = "Sai Dhanshik" },
                        new { Act_id = 10, Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Radhika_Apte_snapped_on_the_sets_of_Midnight_Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg/220px-Radhika_Apte_snapped_on_the_sets_of_Midnight_Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg", Act_name = "Radhika Apte" }
                    );
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Director", b =>
                {
                    b.Property<int>("Director_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director_name");

                    b.HasKey("Director_id");

                    b.ToTable("Directors");

                    b.HasData(
                        new { Director_id = 1, Director_name = "Zoya Akhtar" },
                        new { Director_id = 2, Director_name = "Sankalp Reddy" },
                        new { Director_id = 3, Director_name = "Pa.Ranjith" }
                    );
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Favourite_Mov", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Mov_id");

                    b.Property<int>("User_id");

                    b.HasKey("id");

                    b.HasIndex("Mov_id");

                    b.HasIndex("User_id");

                    b.ToTable("Favourite_Movs");
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Movie", b =>
                {
                    b.Property<int>("Mov_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Avg_rating");

                    b.Property<int>("Director_id");

                    b.Property<string>("Mov_description")
                        .HasMaxLength(500);

                    b.Property<string>("Mov_genrers");

                    b.Property<string>("Mov_image_url")
                        .HasMaxLength(500);

                    b.Property<string>("Mov_name");

                    b.Property<int>("year");

                    b.HasKey("Mov_id");

                    b.HasIndex("Director_id")
                        .IsUnique();

                    b.ToTable("Movies");

                    b.HasData(
                        new { Mov_id = 1, Avg_rating = 7.5f, Director_id = 1, Mov_description = "Gully Boy is a 2019 Indian Hindi-language musical drama film written by Zoya Akhtar and Reema Kagti, and directed by Akhtar.", Mov_genrers = "Drama", Mov_image_url = "https://upload.wikimedia.org/wikipedia/en/0/07/Gully_Boy_poster.jpg", Mov_name = "Gully Boy", year = 2019 },
                        new { Mov_id = 2, Avg_rating = 7.6f, Director_id = 2, Mov_description = "The Ghazi Attack (Ghazi in Telugu) is a 2017 Indian war film written, and directed by Sankalp Reddy.", Mov_genrers = "Action", Mov_image_url = "https://upload.wikimedia.org/wikipedia/en/e/e7/The_Ghazi_Attack_Poster.jpg", Mov_name = "The Gahzi Attack", year = 2017 },
                        new { Mov_id = 3, Avg_rating = 7.1f, Director_id = 3, Mov_description = "Kabali is a 2016 Indian Tamil-language gangster film written and directed by Pa. Ranjith and produced by Kalaipuli S. Thanu.", Mov_genrers = "Thriller", Mov_image_url = "https://upload.wikimedia.org/wikipedia/en/9/9e/Rajinikanth_in_Kabali.jpg", Mov_name = "Kabali", year = 2017 }
                    );
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Movie_Cast", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Act_id");

                    b.Property<int>("Mov_id");

                    b.HasKey("id");

                    b.HasIndex("Act_id");

                    b.HasIndex("Mov_id");

                    b.ToTable("Movie_Casts");
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Rating", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Movie_id");

                    b.Property<int>("User_id");

                    b.Property<int?>("movieMov_id");

                    b.Property<float>("rating");

                    b.HasKey("id");

                    b.HasIndex("User_id");

                    b.HasIndex("movieMov_id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email_id");

                    b.Property<string>("User_name");

                    b.Property<string>("password");

                    b.HasKey("User_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Favourite_Mov", b =>
                {
                    b.HasOne("TheMovieDatabase_api.Models.Movie", "movie")
                        .WithMany("favourite_Movs")
                        .HasForeignKey("Mov_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheMovieDatabase_api.Models.User", "user")
                        .WithMany("favourite_mov")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Movie", b =>
                {
                    b.HasOne("TheMovieDatabase_api.Models.Director", "director")
                        .WithOne("movie")
                        .HasForeignKey("TheMovieDatabase_api.Models.Movie", "Director_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Movie_Cast", b =>
                {
                    b.HasOne("TheMovieDatabase_api.Models.Actor", "actor")
                        .WithMany("movie_cast")
                        .HasForeignKey("Act_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheMovieDatabase_api.Models.Movie", "movie")
                        .WithMany("movie_cast")
                        .HasForeignKey("Mov_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TheMovieDatabase_api.Models.Rating", b =>
                {
                    b.HasOne("TheMovieDatabase_api.Models.User", "user")
                        .WithMany("rating")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TheMovieDatabase_api.Models.Movie", "movie")
                        .WithMany("rating")
                        .HasForeignKey("movieMov_id");
                });
#pragma warning restore 612, 618
        }
    }
}
