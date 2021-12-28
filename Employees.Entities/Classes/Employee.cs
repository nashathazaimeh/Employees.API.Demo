using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Entities
{
    [Table("EMPLOYEE")]
    public class Employee
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("FULL_NAME")]
        public string FullName { get; set; }
        [Column("PHONE_NUMBER")]
        public string PhoneNumber { get; set; }
        [Column("SALARY")]
        public decimal Salary { get; set; }

        [ForeignKey("FK_EMPLOYEE_DEPARTMENT")]
        [Column("DEPARTMENT_ID")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [ForeignKey("FK_EMPLOYEE_COUNTRY")]
        [Column("COUNTRY_ID")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

    }
}
