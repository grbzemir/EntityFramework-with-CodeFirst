using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Entities.CodeFirstMapping
{
    public class OrderMapp: EntityTypeConfiguration<Order>
    {


        public OrderMapp()

        {


            this.HasKey(t => t.OrderId);

            this.Property(t => t.CustomerId)
            .IsFixedLength()
            .HasMaxLength(5);


            this.ToTable("Orders");

            this.Property(t => t.CustomerId)
                .HasColumnName("CustomerId");

            this.Property(t => t.OrderId)
                .HasParameterName("OrderId");


            this.Property(t => t.OrderDate)
                .HasColumnName("OrderDate");

            this.HasOptional(t => t.Customer).WithMany(t => t.Orders)
                .HasForeignKey(d => d.CustomerId);

             this.Property(t => t.ShipCity)
                .HasColumnName("ShipCity");

            this.Property(t => t.ShipCountry)
                .HasColumnName("ShipCountry");





        }


    }
}
