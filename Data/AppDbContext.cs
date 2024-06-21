using Microsoft.EntityFrameworkCore;
using sampleDataDummy.Models;

namespace sampleDataDummy.Data;

public class AppDbContext : DbContext
{
        public AppDbContext(DbContextOptions<AppDbContext> options ): base(options) { }

        public DbSet<Personal> Personals { get; set; }
}