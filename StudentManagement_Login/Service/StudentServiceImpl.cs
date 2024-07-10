using StudentManagement.Repository;
using StudentManagement.Models;
namespace StudentManagement.Service
{
    public class StudentServiceImpl:IStudentService
    {
        public bool StudentLogin(String username, int password)
        {
            return StudentManagerRepo.Login(username, password);
        }

        public bool AdminLogin(String username, int password)
        {
            return StudentManagerRepo.AdminLogin(username, password);
        }

        public Student AddNewStudent(Student student)
        {
            return StudentManagerRepo.AddNewStudent(student);
        }


        public List<Student> GetAllStudent()
        {
            return StudentManagerRepo.GetAllStudents();
        }
        public List<Student> searchStudent(String status)
        {
            return StudentManagerRepo.searchStudent(status);
        }
        public bool deleteStudentByID(int id)
        {
            return StudentManagerRepo.deleteStudentByID(id);
        }
        public List<Student> sortstudentByStatus()
        {
            return StudentManagerRepo.sortstudentByStatus();
        }

        public Student updateStudent(Student std)
        {
            return StudentManagerRepo.updateStudent(std);
        }

        public Student getStudentById(int id)
        {
            return StudentManagerRepo.getStudentById(id);
        }
        public Student EditStudent(Student std)
        {
            return StudentManagerRepo.EditStudent(std);
        }
    }
}
