using EMPLOYEES.DATAACCESS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employees.Services;
using Employees.Entities.Dtos;
using Employees.Entities;

namespace Employees.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {


        private readonly IEmployeeService _emplyeeService;


        public EmployeesController(IEmployeeService emplyeeService)
        {
            _emplyeeService = emplyeeService;
        }

        [HttpGet]
        public IEnumerable<EmployeeListDto> GetAll()
        {
            
            return _emplyeeService.GetAll();
        }

        [HttpGet("{id}")]
        public EmployeeDto GetById(int id)
        {
            return _emplyeeService.GetById(id);
        }

        [HttpPost]
        public int Add([FromBody] EmployeeDto employee)
        {
            try
            {
                return _emplyeeService.Add(employee);

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPut]
        public int Update([FromBody] EmployeeDto employee)
        {
            try
            {
                return _emplyeeService.Update(employee);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _emplyeeService.Delete(id);
        }
    }
}
