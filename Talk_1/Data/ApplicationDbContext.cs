using Microsoft.EntityFrameworkCore;
using Talk_1.Models;

namespace Talk_1.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
