using Employees.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Entities
{
    public interface IEmployeeService
    {
        List<EmployeeListDto> GetAll();
        EmployeeDto GetById(int id);
        int Add(EmployeeDto employee);
        int Update(EmployeeDto employee);
        int Delete(int id);
    }
}
