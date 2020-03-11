using CinemaApp.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.CustomerList
{
    public class CustomersList
    {
        public List<CustomerDetails> ListOfCustomer()
        {
            List<CustomerDetails> ListOfCustomer = new List<CustomerDetails>()
            {
                new CustomerDetails() { CustomerID = 1, Username = "tgv" , Password = "tgv"},
                new CustomerDetails() { CustomerID = 2, Username = "gsc" , Password = "gsc"}
            };
            return ListOfCustomer;
        }
    }
}
