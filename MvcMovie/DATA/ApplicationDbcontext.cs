using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.DATA
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {}
        public DbSet<Person> Person { get; set;}
    }

}
