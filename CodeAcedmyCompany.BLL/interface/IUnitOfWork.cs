using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.BLL.Interface
{
    public interface IUnitOfWork
{
        public IEmployeerepository EmployeeRepository { get; set; }

        public IDepartmentrepository DepartmentRepository { get; set; }
}
}
