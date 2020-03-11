using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieModel
{
    public class MovieTimeDetails
    {
        [Key]
        public int MovieTimeID { get; set; }

        public DateTime MovieTimeStart { get; set; }

        public int MovieID { get; set; }

        public virtual MovieDetails MovieDetails { get; set; }

        public ICollection<MovieSeatDetails> MovieSeatDetails { get; set; }
    }
}
