using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    public class ChallengeController : Controller
    {
        [Authorize(Policy = "B2C-Challenge-Admin")]
        public IActionResult CustomAdmin()
        {
            return View();
        }

        [Authorize(Policy = "B2C-Challenge-Rest")]
        public IActionResult RestAdmin()
        {
            return View();
        }
    }
}