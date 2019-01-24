using login_aspnet_core.Models;
using Microsoft.EntityFrameworkCore;

namespace login_aspnet_core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }

    }

}
