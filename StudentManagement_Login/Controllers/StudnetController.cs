using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service;

namespace StudentManagement.Controllers
{
    public class StudnetController : Controller
    {
        private IStudentService _studentService;
        public StudnetController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult StudentLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentLogin(string username, int password)
        {
            Console.WriteLine(username + " " + password+" "+ _studentService.StudentLogin(username, password));

            if (_studentService.StudentLogin(username, password) == true)
            {
                Console.WriteLine(username + " " + password);
                return RedirectToAction("StudentDetails");
            }
            return View();
        }

        public IActionResult StudentDetails()
        { 
            return View();
        }

    }
}
