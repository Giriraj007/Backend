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
    [Migration("20190225161523_FirstMigration3")]
    partial class FirstMigration3
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
                        .HasMaxLength(200);

                    b.Property<string>("Mov_genrers");

                    b.Property<string>("Mov_image_url");

                    b.Property<string>("Mov_name");

                    b.Property<int>("year");

                    b.HasKey("Mov_id");

                    b.HasIndex("Director_id")
                        .IsUnique();

                    b.ToTable("Movies");
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
