using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
namespace SimpleApp.Controllers

{
    public class StudentController : Controller
    {
       
        public IActionResult MyHome()
        {

            GetStudent gs = new GetStudent();
            Student g = gs.GetStudentDet();

            return View(g);
        }
    }
}
