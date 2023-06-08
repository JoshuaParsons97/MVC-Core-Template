using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}
