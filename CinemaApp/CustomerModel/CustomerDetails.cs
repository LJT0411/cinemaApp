using CinemaApp.MovieModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.CustomerModel
{
    public class CustomerDetails
    {
        [Key]
        public int CustomerID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public virtual ICollection<MovieDetails> MovieDetails { get; set; }

    }
}
