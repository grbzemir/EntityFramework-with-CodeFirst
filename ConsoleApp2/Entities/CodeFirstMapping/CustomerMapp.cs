using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities.CodeFirstMapping
{
    public class CustomerMapp : EntityTypeConfiguration<Customer>
    {

        public CustomerMapp()

        {

            
          this.HasKey(c => c.CustomerId);

            this.Property(t => t.CustomerId)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(c => c.CompanyName).
                IsRequired().
                HasMaxLength(40);

            this.Property(c => c.City)
                .HasMaxLength(15);

            this.Property(c => c.ContactName)
                .HasMaxLength(30);

            this.Property(c => c.Country)
                .HasMaxLength(15);


            this.ToTable("Customers");

            this.Property(c => c.CustomerId)
               .HasColumnName("Customer Id");

            this.Property(c => c.Country)
                .HasColumnName("Country");

            this.Property(c => c.ContactName)
                .HasColumnName("ContactName");

            this.Property(c => c.CompanyName)
                .HasColumnName("CompanyName");

            this.Property(c => c.City)
                .HasColumnName("City");





        }





    }
}
