using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class User
{       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_id { get; set; }
        public string User_name { get; set; }
        public string Email_id { get; set; }
        public string password { get; set; }
        public ICollection<Rating> rating { get; set; }




        public ICollection<Favourite_Mov> favourite_mov { get; set; }
    }
}
