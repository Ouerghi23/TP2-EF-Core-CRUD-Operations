using Microsoft.EntityFrameworkCore;
using TP2.Models;

namespace TP2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet <Movie> Movies {get;set;}
        public DbSet<Genre> Genres { get; set; }
    }
}
