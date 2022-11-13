using DynamicSamllApp.Models;
using Microsoft.AspNetCore.Mvc;


namespace DynamicSamllApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Showstudent(String sname,int sid)
        {
            Student st = new Student();
            st.StudentName = sname;
            st.StudentId = sid;
            
            return View(st);
        }
        public IActionResult GetStudent()
        {
            return View();
        }
    }
}
