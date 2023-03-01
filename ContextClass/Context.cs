using Microsoft.EntityFrameworkCore;
using A_1_3647.Models;

namespace A_1_3647.ContextClass
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<A_1_3647.Models.Category> Category { get; set; }



    }
}
