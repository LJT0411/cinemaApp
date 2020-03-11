﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieModel
{
    public class MovieDetails
    {
        public int MovieID { get; set; }

        public string MovieTitle { get; set; }

        public DateTime MovieTime { get; set; }

        public MAvail MovieAvailable { get; set; }
    }

    public enum MAvail
    {
        [Display(Name = "Now Showing")]
        NowShowing,
        [Display(Name = "Coming Soon")]
        ComingSoon
    }
}
