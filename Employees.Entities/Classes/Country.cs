using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employees.Entities
{
    [Table("COUNTRY")]

    public class Country
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }     

    }
}
