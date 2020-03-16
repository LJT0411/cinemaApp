using CinemaApp.MovieModel;
using CinemaApp.MovieTimeList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CinemaMainScreen CinemaApp = new CinemaMainScreen();
            ss
            MovieStartTime times = new MovieStartTime();
            // Open a list to get the stored data from the MovieStartTime
            List<MovieTimeDetails> ListOfTimes = times.ListOfTime();
            // This list is to save the random seat
            List<MovieSeatDetails> ListOfSeat = new List<MovieSeatDetails>();
            Random SeatA = new Random();

            for (int y = 0; y < ListOfTimes.Count; y++)
            {
                // To check to Hall and give the row.
                var checkHall = ListOfTimes.Where(c => c.MovieHallID == ListOfTimes[y].MovieHallID).SingleOrDefault();
                int check = 0;
                if (checkHall.MovieHallID == 301 || checkHall.MovieHallID == 304)
                    check = 4;
                if (checkHall.MovieHallID == 302 || checkHall.MovieHallID == 305)
                    check = 5;
                if (checkHall.MovieHallID == 303 || checkHall.MovieHallID == 306)
                    check = 6;

                // Loop Row
                for (int i = 1; i < check; i++)
                {
                    // Loop the seat
                    for (int x = 1; x < 11; x++)
                    {
                        // Random the taken and empty
                        SAvail Avail = (SAvail)SeatA.Next(2);

                        MovieSeatDetails SeatList = new MovieSeatDetails
                        {
                            SeatID = +1,
                            SeatNo = i + "," + x,
                            SeatAvail = Avail,
                            MovieTimeID = ListOfTimes[y].MovieTimeID
                        };
                        ListOfSeat.Add(SeatList);
                    }
                }
            }
            // Bring the random seat data to next class
            CinemaApp.CinemaTicketApp(ListOfSeat);
        }
    }
}
