using AutoMapper;
using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.BLL.Interface;
using CodeAcedmyCompany.BLL.repository;
using Microsoft.AspNetCore.Mvc;

namespace CodeAcedmyCompany.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork , IMapper mapper)
        {

            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public IActionResult Index(string search)
        {
            IEnumerable<Employee> emps;
            if (string.IsNullOrEmpty(search))
            {
                emps = _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                emps = _unitOfWork.EmployeeRepository.Search(search);
            }
            return View(emps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var emp = _unitOfWork.EmployeeRepository.Get(id.Value);
            return View(emp);

        }
        public IActionResult Create()
        {
            ViewBag.Departments = _unitOfWork.EmployeeRepository.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            _unitOfWork.EmployeeRepository.Create(emp);

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var emp = _unitOfWork.EmployeeRepository.Get(id);
            ViewBag.Departments = _unitOfWork.DepartmentRepository.GetAll();
            return View(emp);
        }

        [HttpPost]
        public IActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.EmployeeRepository.Update(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public IActionResult Delete(int id)
        {

            var emp = _unitOfWork.EmployeeRepository.Get(id);
            return View(emp);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var emp = _unitOfWork.EmployeeRepository.Get(id);
            _unitOfWork.EmployeeRepository.Delete(emp);
            return RedirectToAction("Index");
        }


    }
}
