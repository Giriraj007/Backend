using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Movie
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Mov_id { get; set; }
        public string Mov_name { get; set; }
        public int year { get; set; }
        public float Avg_rating { get; set; }
        public string Mov_genrers { get; set; }
        public bool isintheator { get; set; }
        //foreign key for Directors
        [ForeignKey("Director")]
        public int Director_id { get; set; }
        public Director director { get; set; }

        [MaxLength(500)]
        public string Mov_description { get; set; }
        [MaxLength(500)]
        public string Mov_image_url { get; set; }
        public ICollection<Movie_Cast> movie_cast { get; set; }
        public ICollection<Rating> rating { get; set; }
        public ICollection<Favourite_Mov> favourite_Movs { get; set; }




    }
}
