using Microsoft.EntityFrameworkCore.Internal;
using Org.BouncyCastle.Tls;
using StudentManagement.Models;
using System.Security.Cryptography.Xml;

namespace StudentManagement.Repository
{
    public static class StudentManagerRepo
    {

        public static bool Login(string username, int password) 
        {
            using (var context = new StudentCollectionContext()) {
                Console.WriteLine(username + " " + password);
                var std=context.dbcontext.Where(s=>s.std_email == username && s.std_phone == password);
                if (std != null) 
                {
                    return true;
                }
                return false;
            }
        }
        public static bool AdminLogin(string username, int password) 
        {  using (var context = new StudentCollectionContext()) {
                var std = context.dbcontext.FirstOrDefault(s => "Admin" == username && 12345 == password);
                if (std != null) {
                    return true;
                }
                return false;
            }
        }


        public static Student AddNewStudent(Student stdent)
        {
            using (var context = new StudentCollectionContext())
            {
                var std = context.dbcontext.Add(stdent);
                context.SaveChanges();
                return stdent;
            }
        }


        public static List<Student> GetAllStudents()
        {
            using (var context = new StudentCollectionContext())
            {
                var std = from s
                          in context.dbcontext
                          select s;
               
                return std.ToList<Student>();
            }

        }

        public static List<Student> searchStudent(String status)
        {
            using (var context = new StudentCollectionContext())
            {
                return context.dbcontext.Where(s=>s.std_status==status).ToList<Student>();
            }
        }

        public static bool deleteStudentByID(int id)
        {
            using (var context = new StudentCollectionContext())
            {
                var std = context.dbcontext.Find(id);
                if(id!=null)
                {
                    var i=context.dbcontext.Remove(std);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static List<Student> sortstudentByStatus()
        {
            using (var context = new StudentCollectionContext())
            {
                return context.dbcontext.OrderBy(s => s.std_status).ToList();
            }
        }


        public static Student updateStudent(Student std)
        {
            using (var context = new StudentCollectionContext())
            {
                var std1 = context.dbcontext.Find(std.std_id);
                if (std1 != null) 
                {
                    std1.std_name=std.std_name;
                    std1.std_phone=std.std_phone;
                    std1.std_Address = std.std_Address;
                    std1.std_email=std.std_email;
                    std1.std_status=std.std_status;
                    std1.std_admissiondate=std.std_admissiondate;
                    std1.std_fees=std.std_fees;
                    context.SaveChanges();
                   
                }
                return std1;
            }

        }

        public static Student getStudentById(int id)
        {
            using (var context = new StudentCollectionContext())
            {
                var std = context.dbcontext.Find(id);
                return std;
            }
        }

        public static Student EditStudent(Student std)
        {
            using (var context = new StudentCollectionContext())
            {
                var std1 = context.dbcontext.Find(std.std_id);
                if (std1 != null)
                {
                    std1.std_name = std.std_name;
                    std1.std_phone = std.std_phone;
                    std1.std_Address = std.std_Address;
                    std1.std_email = std.std_email;
                    std1.std_status = std.std_status;
                    context.SaveChanges();
                }
                return std1;
            }
        }

    }
}
