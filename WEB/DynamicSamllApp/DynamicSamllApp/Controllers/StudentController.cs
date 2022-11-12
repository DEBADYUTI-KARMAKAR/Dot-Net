using Microsoft.AspNetCore.Mvc;

namespace DynamicSamllApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Showstudent(String name,int id)
        {
            
            return View();
        }
        public IActionResult GetStudent()
        {
            return View();
        }
    }
}
