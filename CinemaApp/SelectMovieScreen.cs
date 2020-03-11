using CinemaApp.Functions;
using CinemaApp.MovieList;
using CinemaApp.MovieModel;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaApp
{
    public class SelectMovieScreen
    {
        public void SelectMovie()
        {
            MoviesList movies = new MoviesList();
            List<MovieDetails> ListOfMovies = movies.ListOfMovies();

            bool menu = true;

            while (menu)
            {
                Console.WriteLine("You login as cinema");
                Console.WriteLine("1. Select a movie");
                Console.WriteLine("2. Logout");

                Console.Write("\nEnter your option : ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Select a movie");
                        PrintScreen(ListOfMovies);
                        Console.Write("\nEnter movie id : ");
                        var movieID = int.Parse(Console.ReadLine());

                        var CheckMID = (from c in ListOfMovies
                                        where c.MovieID == movieID
                                        select c).SingleOrDefault();

                        if (CheckMID != null)
                        {
                            Console.Clear();
                            menu = false;

                        }
                        //if (movieID == "101")
                        //{
                        //    Console.Clear();
                        //    menu = false;
                        //    //DateTime.SelectDateATime();
                        //}
                        //else if (movieID == "102")
                        //{
                        //    Console.Clear();
                        //    menu = false;
                        //    //DateTime2.SelectDateATime();
                        //}
                        else
                        {
                            Console.WriteLine("Invalid Option");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;

                    case "2":
                        Console.WriteLine("Thanks for using. Have a nice day!");
                        Thread.Sleep(2000);
                        Console.Clear();
                        CinemaMainScreen logout = new CinemaMainScreen();
                        logout.CinemaTicketApp();
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
        }

        private static void PrintScreen(List<MovieDetails> ListOfMovies)
        {
            var CinemaTable = new ConsoleTable("ID", "Movie Title", "Release Date", "");

            var checkMovie = (from c in ListOfMovies
                              where c.MovieAvailable == MAvail.NowShowing
                              select c).ToList();

            foreach (var movies in checkMovie)
            {
                CinemaTable.AddRow(movies.MovieID, movies.MovieTitle, movies.MovieReleaseTime, DisplayOutput.DisplayOP(movies.MovieAvailable));
            }
            CinemaTable.Write();
        }


    }
}
