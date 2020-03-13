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
                new MovieTimeDetails() { MovieTimeID = 201, MovieTimeStart = new DateTime(2020,02,27,10,0,0) , MovieID = 101 , MovieHallID = 301},
                new MovieTimeDetails() { MovieTimeID = 202, MovieTimeStart = new DateTime(2020,02,27,14,30,0) , MovieID = 101 , MovieHallID = 302},
                new MovieTimeDetails() { MovieTimeID = 203, MovieTimeStart = new DateTime(2020,02,27,18,10,0) , MovieID = 101 , MovieHallID = 303},

                new MovieTimeDetails() { MovieTimeID = 204, MovieTimeStart = new DateTime(2020,02,27,10,0,0) , MovieID = 102 , MovieHallID = 304},
                new MovieTimeDetails() { MovieTimeID = 205, MovieTimeStart = new DateTime(2020,02,27,14,30,0) , MovieID = 102 , MovieHallID = 305},
                new MovieTimeDetails() { MovieTimeID = 206, MovieTimeStart = new DateTime(2020,02,27,18,10,0) , MovieID = 102 , MovieHallID = 306},
            };
            return ListOfTime;
        }
    }
}
