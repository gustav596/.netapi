using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Models
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options):base(options)
        {
                
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Test.Models.Country> Country { get; set; }
    }
}
