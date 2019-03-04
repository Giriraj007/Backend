using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Rating
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        //foreign key for User
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User user { get; set; }

        //foreign key for  Movie
        [ForeignKey("Movie")]
        public int Mov_id { get; set; }
        public Movie movie { get; set; }

        

        public float rating { get; set; }
       


    }
}
