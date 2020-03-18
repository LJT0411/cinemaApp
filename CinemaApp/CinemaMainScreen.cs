using CinemaApp.CustomerList;
using CinemaApp.CustomerModel;
using CinemaApp.Functions;
using CinemaApp.MovieList;
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
    public class CinemaMainScreen
    {
        // This parameter list data brought from program class
        public void CinemaTicketApp(List<MovieSeatDetails> ListOfSeat)
        {
            CustomersList customers = new CustomersList();
            // This list is to get the stored user data from customers list
            List<CustomerDetails> ListOfCustomer = customers.ListOfCustomer();

            MoviesList movies = new MoviesList();
            // This list is to get the stored movie data from movies list
            List<MovieDetails> ListOfMovie = movies.ListOfMovies();

            bool menu = true;
            while (menu)
            {
                Console.WriteLine("Welcome to TGV Cinema Ticket App");
                Console.WriteLine("1. View all movies");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit app\n");

                Console.Write("Enter your option: ");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Print the all cinema by using this method, ListOfMovie has the all movies stored inside.
                        PrintCinemaMovies(ListOfMovie);
                        Console.WriteLine("Login to buy a movie ticket of your favourite movie.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Username : ");
                        var username = Console.ReadLine();

                        Console.Write("\nPassword : ");
                        var password = Console.ReadLine();
                        // This method called from Functions folder, this method used to check the user valid or not
                        // if valid, it will bring over the stored random seat to next class
                        Login.CheckLogin(username, password, ListOfCustomer, ListOfSeat);
                        break;

                    case "3":
                        Console.WriteLine("\nThanks for using. Have a nice day!\n");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nInvalid Option\n");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }
        }
        // This method parameter grab the all the movies from this list
        private static void PrintCinemaMovies(List<MovieDetails> Movies)
        {
            var CinemaTable = new ConsoleTable("Movie Title", "Release Date", "");

            // Loop the list and print the movies
            foreach (var MovieTitle in Movies)
            {
                CinemaTable.AddRow(MovieTitle.MovieTitle, 
                                   $"{MovieTitle.MovieReleaseTime.DayOfWeek} {MovieTitle.MovieReleaseTime.ToString("dd MMMM yyyy")}",
                                   DisplayOutput.DisplayOP(MovieTitle.MovieAvailable));
            }
            CinemaTable.Write();
        }
    }
}
