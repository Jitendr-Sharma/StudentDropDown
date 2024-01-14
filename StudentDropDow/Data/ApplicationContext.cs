using Microsoft.EntityFrameworkCore;
using StudentDropDow.Models.Cascade;

namespace StudentDropDow.Data
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
