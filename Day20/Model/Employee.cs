using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20.Model
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int emp_Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Range(20,65)]
        public int Age { get; set; }
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
    }
}
