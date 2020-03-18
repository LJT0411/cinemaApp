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
        public static void SelectMovie(List<MovieSeatDetails> ListOfSeat)
        {
            MoviesList movies = new MoviesList();
            // This list stored all movies
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
                        // This method grab all movies and print it
                        PrintScreen(ListOfMovies);
                        Console.Write("\nEnter movie id : ");
                        var movieID = Console.ReadLine();

                        // This linq is used to check the movie id valid or not
                        var CheckMID = (from c in ListOfMovies
                                        where c.MovieID.ToString() == movieID
                                        select c).SingleOrDefault();

                        if (CheckMID != null)
                        {
                            Console.Clear();
                            // menu = false , so this will stop the while loop
                            menu = false;
                            // Bring the movie id that is valid and the random seat to the next class
                            SelectMovieTimeScreen.SelectDateTime(CheckMID,ListOfSeat);
                        }
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
                        // Go back to the login page
                        logout.CinemaTicketApp(ListOfSeat);
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

            // This linq is used to show the movies that the status is now showing
            var checkMovie = (from c in ListOfMovies
                              where c.MovieAvailable == MAvail.NowShowing
                              select c).ToList();

            foreach (var movies in checkMovie)
            {
                CinemaTable.AddRow(movies.MovieID, movies.MovieTitle, 
                                   $"{movies.MovieReleaseTime.DayOfWeek}, {movies.MovieReleaseTime.ToString("dd MMMM yyyy")}",
                                   DisplayOutput.DisplayOP(movies.MovieAvailable));
            }
            CinemaTable.Write();
        }
    }
}
