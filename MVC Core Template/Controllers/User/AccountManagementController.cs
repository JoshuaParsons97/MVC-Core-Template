using CoreTemplate.DataModels;
using CoreTemplate.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers.User
{
    public class AccountManagementController : BaseController
    {
        [Authorize]
        public IActionResult Account()
        {
            DataModels.User CurrentUser = new DataModels.User(UserID);
            return View(CurrentUser);
        }
    }
}
