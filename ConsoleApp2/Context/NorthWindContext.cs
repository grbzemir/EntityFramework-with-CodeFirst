using ConsoleApp2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Context
{
    public class NorthWindContext:DbContext
    
    
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }



    }
}
