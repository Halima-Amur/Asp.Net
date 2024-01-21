using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.DAL.Model
{
    public class Department
    {
        public int Id { get; set; }
     
        public string Code { get; set; }
        [MaxLength(50)] 
        public string Name { get; set; }

        public string? ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
