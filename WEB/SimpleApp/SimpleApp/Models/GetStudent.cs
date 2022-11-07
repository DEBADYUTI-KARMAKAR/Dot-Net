namespace SimpleApp.Models
{
    public class GetStudent
    {
        public Student GetStudentDet()
        {
            Student stu = new Student();
            stu.Id = 2001;
            stu.Name = "Deb";
            
            return stu;
        }
    }
}
