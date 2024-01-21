using AutoMapper;
using CodeAcedmyCompany.DAL.Model;
using CodeAcedmyCompany.BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CodeAcedmyCompany.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            // ViewBag || ViewdData
            ViewBag.massage = "Hello from Action";
            ViewData["msg"] = "Hello from ViewData";
            var deps = _unitOfWork.DepartmentRepository.GetAll();
            return View(deps);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            
            var dep = _unitOfWork.DepartmentRepository.Get(id.Value);
            return View(dep);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dep)
        {

            if (ModelState.IsValid)
            {
                dep.ImageUrl = DocumentConf.DocumentUpload(dep.ImageUrl, "Images");
                _unitOfWork.DepartmentRepository.Create(dep);
                TempData["success"] = "Added Successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Update(int id)
        {
            var dep = _unitOfWork.DepartmentRepository.Get(id);
            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Department dep)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.DepartmentRepository.Update(dep);
                return RedirectToAction("Index");
            }
            return View(dep);
        }

        public ActionResult Delete(int id)
        {
            var dep = _unitOfWork.DepartmentRepository.Get(id);
            _unitOfWork.DepartmentRepository.Delete(dep);
            return RedirectToAction("Index");
        }


    }
}
