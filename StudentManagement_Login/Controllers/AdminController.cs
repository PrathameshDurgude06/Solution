using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service;

namespace StudentManagement.Controllers
{
    public class AdminController : Controller
    { 
        private IStudentService _studentService;
        public AdminController(IStudentService studentService) {
           _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminLogin(string username, int password) {
            if (_studentService.AdminLogin(username, password) == true) 
            {
                return RedirectToAction("AdminDetails");
            }
           return View();
        }

        public IActionResult AdminDetails()
        {
            return View();
        }

    }
}
