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

            MovieStartTime times = new MovieStartTime();
            List<MovieTimeDetails> ListOfTimes = times.ListOfTime();
            List<MovieSeatDetails> ListOfSeat = new List<MovieSeatDetails>();
            Random SeatA = new Random();

            for (int y = 0; y < ListOfTimes.Count; y++)
            {
                for (int i = 1; i < 4; i++)
                {
                    for (int x = 1; x < 11; x++)
                    {
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
            CinemaApp.CinemaTicketApp(ListOfSeat);
        }
    }
}
