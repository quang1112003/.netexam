using Microsoft.EntityFrameworkCore;
using testexam.Models;

namespace testexam.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }

    }
}
