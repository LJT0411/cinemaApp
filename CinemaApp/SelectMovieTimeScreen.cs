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
        // This DataTakeOver is stored the movie id that you just entered, and also the random seat
        public static void SelectDateTime(MovieDetails DataTakeOver, List<MovieSeatDetails> ListOfSeat)
        {
            MovieStartTime times = new MovieStartTime();
            // This list grab the stored data from the MovieStartTime
            List<MovieTimeDetails> ListOfTimes = times.ListOfTime();

            // This linq used to check the list of times from the movie id that you entered
            var ListOfTimeID = ListOfTimes.Where(c => c.MovieID == DataTakeOver.MovieID).ToList();

            bool select = true;
            while (select)
            {
                Console.WriteLine("Your movie selection: " + DataTakeOver.MovieTitle);
                Console.WriteLine("Select date and time");
                // This method used to print the list of times
                PrintDateTime(ListOfTimeID);
                Console.WriteLine();
                Console.Write("Enter Id to choose the movie time : ");
                var movieTime = Console.ReadLine();

                // This linq used to check the movie time id is valid or not
                var checkTimeID = (from c in ListOfTimeID
                                   where c.MovieTimeID.ToString() == movieTime
                                   select c).SingleOrDefault();
                
                if (checkTimeID != null)
                {
                    // If the movie id is valid, it will bring the movie time id and random seat to the next class
                    SelectMovieSeatScreen.SelectSeat(checkTimeID, ListOfSeat);
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    // If entered an invalid option, it will go back to the select movie page
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
