using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities
{
    public class Order

    {



        public int OrderId { get; set; }

        public string CustomerId { get; set; }

        public string ShipCity { get; set; }

        public string ShipCountry { get; set; }

        public DateTime OrderDate { get; set; }


        public Customer Customer { get; set; }


    }
}
