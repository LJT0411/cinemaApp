using CinemaApp.MovieModel;
using CinemaApp.MovieTimeList;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class SelectMovieTimeScreen
    {
        public static void SelectDateTime(MovieDetails DataTakeOver, List<MovieSeatDetails> ListOfSeat)
        {
            MovieStartTime times = new MovieStartTime();

            List<MovieTimeDetails> ListOfTimes = times.ListOfTime();

            bool select = true;
            while (select)
            {
                Console.WriteLine("Your movie selection: " + DataTakeOver.MovieTitle);
                Console.WriteLine("Select date and time");
                PrintDateTime(ListOfTimes);
                Console.WriteLine();
                Console.Write("Enter Id to choose the movie time : ");
                var movieTime = Console.ReadLine();

                var checkTimeID = (from c in ListOfTimes
                                   where c.MovieTimeID.ToString() == movieTime
                                   select c).SingleOrDefault();
                
                if (checkTimeID != null)
                {
                    SelectMovieSeatScreen.SelectSeat(checkTimeID, ListOfSeat);
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    SelectMovieScreen.SelectMovie(ListOfSeat);
                }
            }
        }

        private static void PrintDateTime(List<MovieTimeDetails> ListOfDateTime)
        {
            var DateTable = new ConsoleTable("ID", "Date Start Time");

            foreach (var DateTimeList in ListOfDateTime)
            {
                DateTable.AddRow(DateTimeList.MovieTimeID, DateTimeList.MovieTimeStart);
            }
            DateTable.Write();
        }
    }
}
