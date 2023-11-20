using Microsoft.EntityFrameworkCore;
using API_.Net_Azure.Models;

namespace API_.Net_Azure.DataAcces
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
