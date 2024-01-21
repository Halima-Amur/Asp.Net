using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace CodeAcedmyCompany.ViewModels
{
    public class employeeVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50)]
        [MinLength(5)]
        public string Name { get; set; }

        [MaxLength(50)]
        [MinLength(4)]
        public string City { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(18, 33)]
        public int age { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public int? DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
