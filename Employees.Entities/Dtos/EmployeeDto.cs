using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities.Dtos
{
    public  class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        public virtual DepartmentDto Department { get; set; }
        public int CountryId { get; set; }

        public virtual CountryDto Country { get; set; }
    }
}
