using CodeAcedmyCompany.DAL.Context;
using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.BLL.repository
{
    public class DepartmentRepository : GenaricRepository<Department>, IDepartmentrepository
    {

        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {

        }

    
    }
}
