using CinemaApp.MovieList;
using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Functions
{
    public class RandomSeat
    {
        public void RandomSeatAvail()
        {

            Random SeatA = new Random();

            for (int i = 1; i < 4; i++)
            {
                for (int x = 0; x < 11; x++)
                {
                    Avail Avail = (Avail)SeatA.Next(2);

                    MovieSeatDetails SeatList = new MovieSeatDetails
                    {
                        SeatID = +1,
                        SeatNo = i + "," + x,
                        SeatAvail = Avail
                    };
                }
            }
        }
    }
}
