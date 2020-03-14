using CinemaApp.CustomerModel;
using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CinemaApp.Functions
{
    public class Login
    {
        // This parameter grab from the CinemaMainScreen class what you typed, and do the checking
        // it also grab the random seat to here
        public static CustomerDetails CheckLogin (string Username, string Password, List<CustomerDetails> Customers,List<MovieSeatDetails> ListOfSeat)
        {
            // This linq is to check the username valid or not
            var checkAcc = (from c in Customers
                         where c.Username == Username
                         select c).SingleOrDefault();

            if (checkAcc != null)
            {
                if (Password != checkAcc.Password)
                {
                    Console.WriteLine("Invalid username or password");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                else
                {
                    Thread.Sleep(2000);
                    Console.Clear();
                    // Bring random seat to next class
                    SelectMovieScreen.SelectMovie(ListOfSeat);
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                Thread.Sleep(2000);
                Console.Clear();
            }
            return checkAcc;
        }
    }
}
