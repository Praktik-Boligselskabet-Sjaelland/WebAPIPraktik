using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class BosjDbContext : DbContext
    {
        public BosjDbContext(DbContextOptions<BosjDbContext> options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
