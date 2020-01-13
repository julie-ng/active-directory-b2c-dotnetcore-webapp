using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq;
using WebApp_OpenIDConnect_DotNet.Models;

namespace WebApp_OpenIDConnect_DotNet.Controllers
{
    [NotifyChallenge]
    public class ChallengeController : Controller
    {
        private readonly IProgressNotificationService _notifier;

        public ChallengeController(IProgressNotificationService progressNotificationService)
        {
            _notifier = progressNotificationService;
        }

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

        [Authorize(Policy = "B2C-Challenge-Rest")]
        [Authorize(Policy = "B2C-Challenge-Admin")]
        public IActionResult SuperAdmin()
        {
            return View();
        }
    }
}