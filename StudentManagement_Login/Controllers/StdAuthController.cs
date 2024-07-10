using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Service;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StdAuthController : Controller
    {
        private readonly IStudentService _studentService;
        public StdAuthController(IStudentService studentService) 
        {
            _studentService = studentService;
        }
        // GET: StdAuthController
        public ActionResult Index()
        {
            return View();
        }

        

        // GET: StdAuthController/Create
        public IActionResult EditStd()
        {
            return View();
        }

        // POST: StdAuthController/Create
        [HttpPost]
        public IActionResult EditStd(int std_id, string std_name, string std_email, int std_phone, string std_Address, string std_status)
        {

            Console.WriteLine(std_id+""+ std_name, std_email, std_phone, std_Address, std_status);
                _studentService.EditStudent(new Models.Student( std_id,std_name,std_email, std_phone,  std_Address,  std_status));
                return View();
            
        }


        
        public IActionResult GetStudentByID() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResultStudentByID(int id)
        {
            return View(_studentService.getStudentById(id));
        }






    }
}
