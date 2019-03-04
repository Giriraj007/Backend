using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Movie_Cast
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        //forign key for Actors
        [ForeignKey("Actor")]
        public int Act_id { get; set; }
        public Actor actor { get; set; }

        //foreign key for Movies
        [ForeignKey("Movie")]
        public int  Mov_id { get; set; }
        
        public Movie movie { get; set; }

        
        
       


    }
}
