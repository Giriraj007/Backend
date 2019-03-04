using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheMovieDatabase_api.Models
{
    public class Actor
{
   [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public int Act_id { get; set; }
        public string Act_name { get; set; }
        [MaxLength(500)]
        public string Act_image_url { get; set; }
        public ICollection<Movie_Cast> movie_cast{ get; set; }

    }
}
