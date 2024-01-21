using CodeAcedmyCompany.DAL.Context;
using CodeAcedmyCompany.BLL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.BLL.repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IEmployeerepository EmployeeRepository { get ; set ; }
        public IDepartmentrepository DepartmentRepository { get; set ; }

        public UnitOfWork(ApplicationDbContext context)
        {
            EmployeeRepository = new EmployeeRepository(context);

            DepartmentRepository = new DepartmentRepository(context); 
        }
    }
}
