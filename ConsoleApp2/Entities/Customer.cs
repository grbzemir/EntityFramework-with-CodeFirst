using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Customer

    {
         
        public Customer()
        {

            Orders = new List<Order>(); // This is a constructor. It is a method that is called when an instance of a class is created. It is used to initialize the values of data members of the new object. In this case, the constructor is initializing the Orders property to a new List of Order objects. This is done so that the Orders property will never be null. If it is null, then we will get a NullReferenceException when we try to add an Order to the Orders property.
        }
        public string CustomerId { get; set; }

        public string ContactName { get; set; }

        public string CompanyName { get; set; }

        public string City { get; set; }
        
        public string Country { get; set; }

        public List<Order> Orders { get; set; }

    }

}
