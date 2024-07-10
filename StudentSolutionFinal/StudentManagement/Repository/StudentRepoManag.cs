using BOL;
using Microsoft.AspNetCore.Connections;

namespace DAL
{
    public class StudentRepoManag : IStudentRepoManag
    {
        private readonly ConnectionContext connectionContext= new ConnectionContext();

        
        public List<Student> Getall()
        {
            return connectionContext.students.ToList();


        }
    }
}
