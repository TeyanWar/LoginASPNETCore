using LoginData.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        //public DbSet<Person> Persons { get; set; }
    }

}
