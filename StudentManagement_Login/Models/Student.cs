namespace StudentManagement.Models
{
    public class Student
    {

        public int std_id { get; set; }
        public string std_name { get; set; }
        public string std_email { get; set; }
        public int std_phone { get; set; }
        public string std_Address { get; set; }
        public DateTime std_admissiondate { get; set; }
        public int std_fees { get; set; }
        public string std_status { get; set; }

        public Student(int std_id, string std_name, string std_email, int std_phone, string std_Address, DateTime std_admissiondate, int std_fees, string std_status)
        {
            this.std_id = std_id;
            this.std_name = std_name;
            this.std_email = std_email;
            this.std_phone = std_phone;
            this.std_Address = std_Address;
            this.std_admissiondate = std_admissiondate;
            this.std_fees = std_fees;
            this.std_status = std_status;
        }

        public Student()
        {
        }

        public Student(int std_id,string std_name, string std_email, int std_phone, string std_Address, string std_status)
        {
            this.std_id = std_id;
            this.std_name = std_name;
            this.std_email = std_email;
            this.std_phone = std_phone;
            this.std_Address = std_Address;
            this.std_status = std_status;
        }
    }
}
