using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.DAL.Model;
using System.ComponentModel.DataAnnotations;

namespace CodeAcedmyCompany.ViewModels
{
    public class DepartmentVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is Required for the Department")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name is Required for the Department")]
        [MaxLength(50)] // nvarchar(max)
        public string Name { get; set; }

        public string? ImageUrl { get; set; }

        public IFormFile Image { get; set; }
        ICollection<Employee> Employes { get; set; } = new HashSet<Employee>();
    }
}
