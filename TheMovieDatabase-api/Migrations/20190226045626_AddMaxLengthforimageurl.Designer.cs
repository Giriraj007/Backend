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
    [Migration("20190226045626_AddMaxLengthforimageurl")]
    partial class AddMaxLengthforimageurl
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
