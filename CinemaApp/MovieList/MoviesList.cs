using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieList
{
    public class MoviesList
    {
        public List<MovieDetails> ListOfMovies()
        {
            List<MovieDetails> ListOfMovies = new List<MovieDetails>()
            {
                new MovieDetails() { MovieID = 101, MovieTitle = "The Justice League", MovieReleaseTime = new DateTime(2020, 03, 01), MovieAvailable = MAvail.NowShowing },
                new MovieDetails() { MovieID = 102, MovieTitle = "The Matrix", MovieReleaseTime = new DateTime(2020, 03, 02), MovieAvailable = MAvail.NowShowing },
                new MovieDetails() { MovieID = 103, MovieTitle = "The Avengers", MovieReleaseTime = new DateTime(2020, 03, 06), MovieAvailable = MAvail.ComingSoon },
                new MovieDetails() { MovieID = 104, MovieTitle = "Lord of The Rings", MovieReleaseTime = new DateTime(2020, 03, 10), MovieAvailable = MAvail.ComingSoon }

            };
            return ListOfMovies;
        }
    }
}
