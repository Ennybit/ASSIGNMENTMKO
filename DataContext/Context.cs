using ASSIGNMENTMKO.Model;
using Microsoft.EntityFrameworkCore;

namespace ASSIGNMENTMKO.DataContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        { 

        }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<SideOrder> SideOrders { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Burger> Burgers { get; set; }
    }
}
