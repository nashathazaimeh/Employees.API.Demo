using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Entities
{
    [Table("DEPARTMENT")]

    public class Department
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }     

    }
}
