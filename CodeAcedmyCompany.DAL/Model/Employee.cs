using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public string Email { get; set; }

        public int age { get; set; }

        public decimal Salary { get; set; }


        public int? DepartmentId { get; set; } 


        public Department Department { get; set; }
    }
}
