using BOL;
using DAL;
using SL;

namespace StudentManagement.Service
{
    public class StudentServiceImpl : IStudentService

    {
        private readonly IStudentRepoManag studentRepoManag;

        public StudentServiceImpl(IStudentRepoManag studentRepo)
        {
            studentRepoManag = studentRepo;
        }
        public List<Student> GetAll()
        {
            return studentRepoManag.Getall();
        }
    }
}
