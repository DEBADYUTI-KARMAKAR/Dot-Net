using Microsoft.AspNetCore.Mvc;

namespace Simple_firstApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Myhome()
        {

            return View();
        }
        public string Index()
        {
            
            return "Hello";
        }
    }
}
