using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace MultiLangDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = _localizer["WelcomeMessage"];
            return View();
        }
    }
}
