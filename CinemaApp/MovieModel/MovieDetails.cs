using CinemaApp.CustomerModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieModel
{
    public class MovieDetails
    {
        [Key]
        public int MovieID { get; set; }

        public string MovieTitle { get; set; }

        public string MovieReleaseTime { get; set; }

        public MAvail MovieAvailable { get; set; }

        public virtual ICollection<MovieTimeDetails> MovieTimeDetails { get; set; }
    }

    public enum MAvail
    {
        [Display(Name = "Now Showing")]
        NowShowing,
        [Display(Name = "Coming Soon")]
        ComingSoon
    }
}
