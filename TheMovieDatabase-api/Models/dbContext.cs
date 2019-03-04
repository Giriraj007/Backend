using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class dbContext:DbContext
{
      public   dbContext(DbContextOptions options):base(options)
        {


        }


        public DbSet<Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Actor> Actorss { get; set; }
        public DbSet<Movie_Cast> Movie_Casts { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Favourite_Mov> Favourite_Movs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Movie>().HasData(new Movie
            {Mov_id=1,
                Mov_name = "Gully Boy",
                year = 2019,
                Avg_rating = 7.5f,
                Mov_genrers = "Drama",
                Mov_description = "Gully Boy is a 2019 Indian Hindi-language musical drama film written by Zoya Akhtar" +
            " and Reema Kagti, and directed by Akhtar.",
                Director_id = 1,
                Mov_image_url= "https://upload.wikimedia.org/" +
                "wikipedia/en/0/07/Gully_Boy_poster.jpg"
            },new Movie
            {   Mov_id=2,
                Mov_name = "The Gahzi Attack",
                year = 2017,
                Avg_rating = 7.6f,
                Mov_genrers = "Action",
                Mov_description = "The Ghazi Attack (Ghazi in Telugu)" +
                " is a 2017 Indian war" +
                " film written, and directed " +
                "by Sankalp Reddy.",
                Director_id = 2,
                Mov_image_url= "https://upload.wikimedia.org" +
                "/wikipedia/en/e/e7/The_Ghazi_Attack_Poster.jpg"


            },new Movie
            {   Mov_id=3,
                Mov_name = "Kabali",
                year = 2017,
                Avg_rating = 7.1f,
                Mov_genrers = "Thriller",
                Mov_description = "Kabali is a 2016 Indian Tamil-language gangster" +
                " film written and directed by Pa. Ranjith and produced by Kalaipuli S." +
                " Thanu.",
                Director_id = 3,
                Mov_image_url= "https://upload.wikimedia." +
                "org/wikipedia/en/9/9e/Rajinikanth_in_Kabali.jpg"


            });

            modelBuilder.Entity<Director>().HasData(new Director
            {Director_id=1,
            Director_name="Zoya Akhtar"



            }, new Director
            {
                Director_id = 2,
                Director_name = "Sankalp Reddy"



            },
            new Director
            {
                Director_id = 3,
                Director_name = "Pa.Ranjith"



            });
            modelBuilder.Entity<Actor>().HasData(new Actor
            {

                Act_id = 1,
                Act_name = "Ranveer Singh",
                Act_image_url = "https://filmfare.wwmindia.com/con" +
                "tent/2019/jan/ranveersinghweb1547459320.jpg"



            },
           new Actor
           {

               Act_id = 2,
               Act_name = "Alia Bhatt",
               Act_image_url = "https://image.tmdb.org/t/p/w600_and" +
               "_h900_bestv2/gu1Sf68cuMgSxSXIsVqG00aCmSy.jpg"



           },
           new Actor
           {

               Act_id = 3,
               Act_name = "Kalki Koechin",
               Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/" +
               "6/68/Kalki_Koechlin_launches_beautifulhomes.jpg"



           },
           new Actor
           {

               Act_id = 4,
               Act_name = "Kubbra Sait",
               Act_image_url = "https://m.media-amazon.com/images/M/MV5BYjgwNDZlZGQtZjFiN" +
               "y00ODQ5LWEzZGUtNWQzNDc4M2QxNmZiXkEyXkFqcGdeQXVyMjIxODkxM" +
               "zk@._V1_UX214_CR0,0,214,317_AL__QL50.jpg"



           },
           new Actor
           {

               Act_id = 5,
               Act_name = "Vijay Raaz",
               Act_image_url = "https://image.tmdb.org/t/p/w600_" +
               "and_h900_bestv2/bLSjiy51UPjVnTYRDmgRUy1VOwD.jpg"



           },  new Actor
           {

               Act_id = 6,
               Act_name = "Rana Duggubati",
               Act_image_url = "https://static.toiimg.com/thumb/imgsize-78019," +
               "msid-56888342,width-400,resizemode-4/56888342.jpg"



           }, new Actor
           {

               Act_id = 7,
               Act_name = "Taapsee Pannu",
               Act_image_url = "https://akm-img-a-in.tosshub.com/indiatoday/images/story/201812/taapse" +
               "e_pannu_0.jpeg?swpYv59n0DftpyK.d0ZReuGVJML8VoRw"



           }, new Actor
           {

               Act_id = 8,
               Act_name = "Rajinikanth",
               Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg/22" +
               "0px-Rajinikanth_at_the_Inauguration_of_MGR_Statue.jpg"



           }, new Actor
           {

               Act_id = 9,
               Act_name = "Sai Dhanshik",
               Act_image_url = "https://timesofindia.indiatimes.com/thumb/msid-" +
               "60900885,width-800,height-600,resizemode-4/60900885.jpg"



           },
           new Actor
           {

               Act_id = 10,
               Act_name = "Radhika Apte",
               Act_image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Radhika_Apte_snapped_on_the_sets_of_Midnight_Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg/220px-Radhika_Apte_snapped_on_the_sets_of_Midnight_" +
               "Misadventures_with_Mallika_Dua_%2806%29_%28cropped%29.jpg"



           });


            modelBuilder.Entity<Movie_Cast>().HasData(new Movie_Cast
            {
                Act_id = 1,
                Mov_id=1,
                id=1
            }, new Movie_Cast
            {
                Act_id = 2,
                Mov_id = 1,
                id = 2
            }, new Movie_Cast
            {
                Act_id = 3,
                Mov_id = 1,
                id = 3
            }, new Movie_Cast
            {
                Act_id = 4,
                Mov_id = 1,
                id = 4
            },
            new Movie_Cast
            {
                Act_id = 5,
                Mov_id = 1,
                id = 5
            }, new Movie_Cast
            {
                Act_id = 6,
                Mov_id = 2,
                id = 6
            }, new Movie_Cast
            {
                Act_id = 7,
                Mov_id = 2,
                id = 7
            }, new Movie_Cast
            {
                Act_id = 8,
                Mov_id = 3,
                id = 8
            }, new Movie_Cast
            {
                Act_id = 9,
                Mov_id = 3,
                id = 9
            }, new Movie_Cast
            {
                Act_id = 10,
                Mov_id = 3,
                id = 10
            });



            modelBuilder.Entity<User>().HasData(new User
            { User_id = 1,
                User_name = "Giriraj",
                Email_id = "bhatiagiriraj007@gmail.com",
                password = "123456"



            });
            modelBuilder.Entity<Rating>().HasData(new Rating
            {


                User_id = 1,
                Mov_id = 1,
                rating = 7.5f,
                id=1
                
            });

            modelBuilder.Entity<Favourite_Mov>().HasData(new Favourite_Mov
            {
                Mov_id = 1,
               User_id=1,
               id=1
               

            });








        }



    }
}
