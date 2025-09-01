using Microsoft.EntityFrameworkCore;

namespace DepartmentWebApp.Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Department> DepSet { get; set; }
    }
}
