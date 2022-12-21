using ClientSideValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClientSideValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new List<string>());
        }

        [HttpPost]
        public IActionResult Index(bool doNotUse)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                list.Add($"item-{i}");
            }

            return View(list);
        }


        public PartialViewResult GetListViewPartial()
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                list.Add($"item-{i}");
            }

            return PartialView("_ListViewPartial", list);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // login kontrolü ve yönlendirme..
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}