using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Director 
{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Director_id { get; set; }
        public string Director_name { get; set; }
        public Movie movie { get; set; }

      


}
}
