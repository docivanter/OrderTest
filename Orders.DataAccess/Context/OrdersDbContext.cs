using Microsoft.EntityFrameworkCore;
using Orders.DattaAcces.Entities;

namespace Orders.DataAccess.Context
{
    public class OrdersDbContext : DbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define default data for Order 1
            Order order1 = new Order
            {
                Id = 1,
                Name = "New York Building 1",
                State = "NY",
            };

            Order order2 = new Order
            {
                Id = 2,
                Name = "California Hotel AJK",
                State = "CA",
            };

            modelBuilder.Entity<Order>().HasData(order1, order2);

            // Define default data for Windows related to Order 1
            modelBuilder.Entity<Window>().HasData(
                new Window { Id = 1, Name = "A51", QuantityOfWindows = 4, TotalSubElements = 3, OrderId = 1  },
                new Window { Id = 2, Name = "C Zone 5", QuantityOfWindows = 2, TotalSubElements = 1, OrderId = 1 }
            );

            // Define default data for SubElements related to Windows
            modelBuilder.Entity<SubElement>().HasData(
                new SubElement { Id = 1, Element = 1, Type = "Doors", Width = 1200, Height = 1850, WindowId = 1 },
                new SubElement { Id = 2, Element = 2, Type = "Window", Width = 800, Height = 1850, WindowId = 1 },
                new SubElement { Id = 3, Element = 3, Type = "Window", Width = 700, Height = 1850, WindowId = 1 },
                new SubElement { Id = 4, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 2 }
            );

            // Define default data for Windows related to Order 2
            modelBuilder.Entity<Window>().HasData(
                new Window { Id = 3, Name = "GLB", QuantityOfWindows = 3, TotalSubElements = 2, OrderId = 2},
                new Window { Id = 4, Name = "OHF", QuantityOfWindows = 10, TotalSubElements = 2, OrderId = 2}
            );

            // Define default data for SubElements related to Windows
            modelBuilder.Entity<SubElement>().HasData(
                new SubElement { Id = 5, Element = 1, Type = "Doors", Width = 1400, Height = 2200, WindowId = 3 },
                new SubElement { Id = 6, Element = 2, Type = "Window", Width = 600, Height = 2200, WindowId = 3 },
                new SubElement { Id = 7, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 4 },
                new SubElement { Id = 8, Element = 1, Type = "Window", Width = 1500, Height = 2000, WindowId = 4 }
            );
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<SubElement> SubElements { get; set; }
    }
}
