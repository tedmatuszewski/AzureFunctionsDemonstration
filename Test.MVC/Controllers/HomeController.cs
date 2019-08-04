using Microsoft.AspNetCore.Mvc;
using Test.Domain.Services;

namespace Test.MVC.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(ITestService service) : base(service)
        {
        }

        public IActionResult Index()
        {
            var response = _service.SendAllWidgetEmails();

            return View();
        }
    }
}
