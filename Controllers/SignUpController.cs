using Microsoft.AspNetCore.Mvc;

namespace RideSharingApplication.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
