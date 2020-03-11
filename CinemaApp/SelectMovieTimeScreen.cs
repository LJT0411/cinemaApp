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
        public static void SelectDateTime(MovieDetails DataTakeOver)
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
                var movieTime = int.Parse(Console.ReadLine());

                var checkTimeID = (from c in ListOfTimes
                                   where c.MovieTimeID == movieTime
                                   select c).SingleOrDefault();
                
                if (checkTimeID != null)
                {

                }
                //if (movieTime == "201")
                //{
                //    //Selection201(ListOfRow1, ListOfRow2, ListOfRow3);
                //}
                //else if (movieTime == "202")
                //{
                //    //Selection202(_202ListOfRow1, _202ListOfRow2, _202ListOfRow3);
                //}
                //else if (movieTime == "203")
                //{
                //    //Selection203(_203ListOfRow1, _203ListOfRow2, _203ListOfRow3);
                //}
                else
                {
                    Console.WriteLine("Invalid Option");
                    Thread.Sleep(1000);
                    Console.Clear();
                    SelectMovieScreen.SelectMovie();
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
