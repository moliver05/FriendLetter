using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/journal")]
        public ActionResult Journal()
        {
          return View();
        }
  }
}
