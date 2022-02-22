using CoureTechnologies.Models;
using Microsoft.EntityFrameworkCore;

namespace CoureTechnologies
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions<CountryDbContext> options) : base(options)
        { }

            public DbSet<User> User { get; set; }
            public DbSet<Country> Country { get; set; }
            public DbSet<CountryDetails> CountryDetails { get; set; }
         
    }
}
