using AutoMapper;
using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.ViewModels;

namespace CodeAcedmyCompany.ProfileModel
{
    public class DepartmentProfile :Profile
    {
        public DepartmentProfile() {
            CreateMap<DepartmentVM, Department>();
        }
    }
}
