using Microsoft.EntityFrameworkCore;
using PROG6212_POEPART1.Models;

namespace PROG6212_POEPART1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Lecturer> lecturers { get; set; }
        public DbSet<Claim> claims { get; set; }
    }
}
