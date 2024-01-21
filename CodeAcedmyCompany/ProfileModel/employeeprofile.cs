using AutoMapper;
using CodeAcedmyCompany.ViewModels;

namespace CodeAcedmyCompany.ProfileModel
{
    public class employeeprofile:Profile
    {
        public employeeprofile()
        {
            CreateMap<employeeVM, employeeVM>();
        }
    }
}
