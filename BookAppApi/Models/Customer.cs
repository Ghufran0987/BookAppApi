using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAppApi.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string pass { get; set; }
        public string Country { get; set; }

        public string PhoneNumber { get; set; }



    }
}
