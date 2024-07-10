using StudentManagement.Models;
namespace StudentManagement.Service
{
    public interface IStudentService
    {
        public bool StudentLogin(String username,int password);
        public bool AdminLogin(String username,int password);

        public Student AddNewStudent(Student student);

        public List<Student> GetAllStudent();
        public List<Student> searchStudent(String status);
        public  bool deleteStudentByID(int id);
        public List<Student> sortstudentByStatus();

        public Student updateStudent(Student std);

        public Student getStudentById(int id);
        public  Student EditStudent(Student std);
    }
}
