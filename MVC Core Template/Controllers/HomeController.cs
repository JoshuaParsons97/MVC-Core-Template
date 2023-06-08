using CoreTemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static CoreTemplate.Enums;

namespace CoreTemplate.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            Notification Error = new("Controller Error Example", "This is an error notification from the controller which works on page load", NotificationType.Error);
            AddNotification(Error);

            Notification Success = new("Controller Success Example", "This a success notification from the controller which works on page load", NotificationType.Success);
            AddNotification(Success);

            Notification Info = new("Controller Info Example", "This an information notification from the controller which works on page load", NotificationType.Info);
            AddNotification(Info);

            return View();
        }

        public IActionResult Legal(Enums.LegalTextType TextType = Enums.LegalTextType.TermsAndConditions)
        {
            ViewBag.TextType = TextType;
            return View("~/Views/Legal/Legal.cshtml");
        }
    }
}
