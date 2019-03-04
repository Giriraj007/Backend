using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Favourite_Mov
{
        //foreign key for Movie
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [ForeignKey("Movie")]
        public int Mov_id { get; set; }
    public Movie movie { get; set; }

        //foreign key for User
        [ForeignKey("User")]
        public int User_id { get; set; }
        public User user { get; set; }
        

        


        
}
}
