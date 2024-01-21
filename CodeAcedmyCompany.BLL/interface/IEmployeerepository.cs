using CodeAcedmyCompany.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcedmyCompany.BLL.Interface
{
    public interface IEmployeerepository : IGenaricrepository<Employee>
    {
        IEnumerable<Employee> Search(string search);
    }
}
