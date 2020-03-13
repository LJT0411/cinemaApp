using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieTimeList
{
    public class MovieStartTime
    {
        public List<MovieTimeDetails> ListOfTime()
        {
            List<MovieTimeDetails> ListOfTime = new List<MovieTimeDetails>()
            {
                new MovieTimeDetails() { MovieTimeID = 201, MovieTimeStart = "27/2/2020 10:00:00 AM" , MovieID = 101},
                new MovieTimeDetails() { MovieTimeID = 202, MovieTimeStart = "27/2/2020 2:30:00 PM" , MovieID = 101},
                new MovieTimeDetails() { MovieTimeID = 203, MovieTimeStart = "27/2/2020 6:10:00 PM" , MovieID = 101},

                new MovieTimeDetails() { MovieTimeID = 204, MovieTimeStart = "27/2/2020 10:00:00 AM" , MovieID = 102},
                new MovieTimeDetails() { MovieTimeID = 205, MovieTimeStart = "27/2/2020 2:30:00 PM" , MovieID = 102},
                new MovieTimeDetails() { MovieTimeID = 206, MovieTimeStart = "27/2/2020 6:10:00 PM" , MovieID = 102},
            };
            return ListOfTime;
        }
    }
}
