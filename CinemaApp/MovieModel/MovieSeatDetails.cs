using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.MovieModel
{
    public class MovieSeatDetails
    {
        [Key]
        public int SeatID { get; set; }

        public string SeatNo { get; set; }

        public Avail SeatAvail { get; set; }

        public int MovieTimeID { get; set; }

        public virtual MovieTimeDetails MovieTimeDetails { get; set; }

    }

    public enum Avail
    {
        E,T
    }
}
