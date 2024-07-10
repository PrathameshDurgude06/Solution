using Microsoft.AspNetCore.Mvc;
using SL;
using BOL;
using DAL;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly ConnectionContext connectionContext = new ConnectionContext();
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllStudents()
        {
            List<Student> students = _studentService.GetAll();
            return View(students);
        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Student student)
        {
            connectionContext.students.Add(student);
            connectionContext.SaveChanges();
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult Update(int id)
        {
            var student = connectionContext.students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            Student newstud=connectionContext.students.Find(student.Student_id);
            newstud.Student_Name=student.Student_Name;
            newstud.Email=student.Email;
            newstud.Mobile_No=student.Mobile_No;
            newstud.Address=student.Address;
            newstud.Admission_date=student.Admission_date;
            newstud.Fees=student.Fees;
            newstud.Status=student.Status;
            connectionContext.SaveChanges();
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult Delete(int id)
        {
            connectionContext.students.Remove(connectionContext.students.Find(id));
            connectionContext.SaveChanges();
            return RedirectToAction("GetAllStudents");
        }

        public IActionResult View(int id)
        {
            var student = connectionContext.students.Find(id);
            return View(student);
        }

        public IActionResult Sort()
        {
            List<Student>students=connectionContext.students.ToList();
            students.Sort((x,y)=>x.Status.CompareTo(y.Status));
            return View(students);
        }

        public IActionResult SortByFees()
        {
            List<Student> students = connectionContext.students.ToList();
            students.Sort((x, y) => x.Fees.CompareTo(y.Fees));
            return View(students);
        }

        [HttpGet]
        public IActionResult GetDateByInput()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchByDate(DateTime date)
        {
            //DateTime.TryParse(date, out DateTime result);
            List<Student> students = connectionContext.students
            .Where(s => s.Admission_date ==date)
            .ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult SearchByName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchName(String name)
        {
            List<Student> students=connectionContext.students.ToList();
            List<Student> newList = new List<Student>();
            foreach (Student student in students)
            {
                if(student.Student_Name.Equals(name))
                    newList.Add(student);
            }
            return View(newList);
        }






    }
}
