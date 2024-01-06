using Microsoft.EntityFrameworkCore;
using TechcareerDotnetBootcamp.Models;

namespace TechcareerDotnetBootcamp
{
    public class TechCareerDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public TechCareerDbContext(DbContextOptions<TechCareerDbContext> options) : base(options)
        {
        }
    }
}
