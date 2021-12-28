using Microsoft.EntityFrameworkCore;
using Employees.Entities;

namespace EMPLOYEES.DATAACCESS
{

    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<CountryDto> Countries { get; set; }

    }

}
