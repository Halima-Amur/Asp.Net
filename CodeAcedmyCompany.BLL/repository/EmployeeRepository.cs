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
    public class EmployeeRepository : GenaricRepository <Employee>,IEmployeerepository
    {

        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

      public IEnumerable<Employee> Search(string name)
        {
            var emp = _context.Employes.Where(w => w.Name.ToLower().Contains(name.ToLower())).ToList();
            return emp;
        }



    }
}
