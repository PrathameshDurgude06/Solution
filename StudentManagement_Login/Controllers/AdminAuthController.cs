using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service;

namespace StudentManagement.Controllers
{
    public class AdminAuthController : Controller
    {
        private IStudentService _studentService;
        public AdminAuthController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(int std_id, string std_name, string std_email, int std_phone, string std_Address, DateTime std_admissiondate, int std_fees, string std_status)
        {
            var std=_studentService.AddNewStudent(new Models.Student(std_id, std_name, std_email, std_phone, std_Address, std_admissiondate, std_fees, std_status));
            return View();
        }

        public IActionResult GetAllStudent()
        {
            return View(_studentService.GetAllStudent());
        }

        public IActionResult SortStudent()
        {
            return View(_studentService.sortstudentByStatus());
        }

        [HttpGet]
        public IActionResult SearchStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResultSearchStudent(string s)
        {
            return View(_studentService.searchStudent(s));
        }
        [HttpGet]
        public IActionResult deleteStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult deleteStudent(int id) 
        {

            _studentService.deleteStudentByID(id);
            return View();
        }

        [HttpGet]
        public IActionResult UpdateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateStudent(int std_id, string std_name, string std_email, int std_phone, string std_Address, DateTime std_admissiondate, int std_fees, string std_status)
        {
            var std = _studentService.updateStudent(new Models.Student(std_id, std_name, std_email, std_phone, std_Address, std_admissiondate, std_fees, std_status));
            return View();
        }



    }
}
