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
    public class SelectMovieSeatScreen
    {
        public static void SelectSeat(MovieTimeDetails MovieSeat, List<MovieSeatDetails> ListOfSeat)
        {
            Console.Clear();

            Console.WriteLine("Cinema Hall Seatings");
            PrintSeat(MovieSeat,ListOfSeat);

            Console.Write("\n\nEnter a seat number (row,column). Example 1,2 : ");
            var seatNumber = Console.ReadLine();

            var checkSeat = (from c in ListOfSeat
                               where c.MovieTimeID == MovieSeat.MovieTimeID
                               select c).ToList();

            var checkNumber = (from c in checkSeat
                               where c.SeatNo == seatNumber
                               select c).SingleOrDefault();

            if (checkNumber != null)
            {
                if (checkNumber.SeatAvail != SAvail.T)
                {
                    Console.WriteLine("Confirm Order? Yes/No");
                    var confirmation = Console.ReadLine();

                    if (confirmation == "Yes" || confirmation == "yes")
                    {
                        checkNumber.SeatAvail = SAvail.T;
                        PrintResult("Success Purchase");
                    }
                    else
                    {
                        PrintResult("Canceled Order");
                    }
                }
                else
                {
                    PrintResult("Sorry. This seat was taken.");
                }
            }
            else
            {
                PrintResult("Invalid Seat Number.");
            }
        }

        private static void PrintSeat(MovieTimeDetails MovieSeat, List<MovieSeatDetails> ListOfSeat)
        {
            var Rows = new ConsoleTable("T: Taken", "E: Empty", "F: Faulty", "L: Locked");

            Rows.Options.EnableCount = false;
            Rows.Write();

            var checkHall = (from c in ListOfSeat
                             where c.MovieTimeID == MovieSeat.MovieTimeID
                             select c).ToList();

            foreach (var Seat in checkHall)
            {
                Console.Write(Seat.SeatNo + " " + Seat.SeatAvail + "\t");
                if (Seat.SeatNo.EndsWith("1,10"))
                {
                    Console.WriteLine("\n");
                }
                if (Seat.SeatNo.EndsWith("2,10"))
                {
                    Console.WriteLine("\n");
                }
                if (Seat.SeatNo.EndsWith("3,10"))
                {
                    Console.WriteLine("\n");
                }
            }
        }

        private static string PrintResult(string result)
        {
            Console.WriteLine(result);
            Thread.Sleep(2000);
            Console.Clear();
            return result;
        }
    }
}
