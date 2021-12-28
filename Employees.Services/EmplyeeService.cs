using System;
using System.Collections.Generic;
using System.Linq;
using Employees.Entities.Dtos;
using EMPLOYEES.DATAACCESS;
using Microsoft.EntityFrameworkCore;
using Employees.Entities;
namespace Employees.Services
{
    public class EmplyeeService : IEmployeeService
    {
        private readonly EmployeeContext _dbContext;


        public EmplyeeService(EmployeeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<EmployeeListDto> GetAll()
        {
            // get all emplyees from db then fill emplyee list dto

            return _dbContext.Employees.Include(a => a.Country).Include(a => a.Department).Select(a => new EmployeeListDto()
            {
                Id = a.Id,
                Name = a.FullName
            }).ToList();

        }
        public EmployeeDto GetById(int id)
        {
            return _dbContext.Employees.Include(a => a.Country).Include(a => a.Department).Select(a => new EmployeeDto()
            {
                Id = a.Id,
                FullName = a.FullName,
                Salary = a.Salary,
                PhoneNumber = a.PhoneNumber,
                Country = new Entities.CountryDto()
                {
                    Id = a.Country.Id,
                    Name = a.Country.Name
                },
                Department = new Entities.DepartmentDto()
                {
                    Id = a.Department.Id,
                    Name = a.Department.Name
                }
            }).FirstOrDefault(a => a.Id == id);
        }

        public int Add(EmployeeDto employee)
        {
            // map emplyee dto to employee context class
            Employee emp = new Employee()
            {
                CountryId = employee.CountryId,
                DepartmentId = employee.DepartmentId,
                FullName = employee.FullName,
                PhoneNumber = employee.PhoneNumber,
                Salary = employee.Salary
            };
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return emp.Id;
        }

        public int Update(EmployeeDto employee)
        {
            // map emplyee dto to employee context class
            Employee emp = new Employee()
            {
                Id = employee.Id,
                CountryId = employee.CountryId,
                DepartmentId = employee.DepartmentId,
                FullName = employee.FullName,
                PhoneNumber = employee.PhoneNumber,
                Salary = employee.Salary
            };
            _dbContext.Employees.Update(emp);
            _dbContext.SaveChanges();
            return emp.Id;
        }

        public int Delete(int id)
        {
            // check if the target emplyee exist in db 
            var employee = _dbContext.Employees.FirstOrDefault(a => a.Id == id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }

            return employee.Id;
        }
    }
}
